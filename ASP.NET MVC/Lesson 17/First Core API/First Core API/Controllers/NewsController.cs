using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using First_Core_API.DTO;
using First_Core_API.DTO.Result;
using First_Core_API.Entity;
using First_Core_API.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_Core_API.Controllers
{
    // localhost:1233/api/News
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {

        private readonly EFContext _context;
        public NewsController(EFContext context)
        {
            _context = context;
        }

        //GET: locahost:1233/api/News/getNews
        [HttpGet("getNews")]
        public List<NewsDTO> getNews()
        {
            var data = _context.News.Select(t => new NewsDTO
            {
                Author = t.Author,
                DateRelease = t.DateRelease,
                Description = t.Description,
                Id = t.Id,
                Title = t.Title
            }).ToList();

            return data;
        }

        [HttpPost("addNews")]
        public ResultDTO addNews([FromBody]CreateNewsDTO dto)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return new ResultErrorDTO
                    {
                       Code = 400,
                       Message = "Invalid data",
                       Error = CustomValidator.getErrorsByModel(ModelState)
                    };
                }
                _context.News.Add(new News
                {
                    Author = dto.Author,
                    DateRelease = dto.DateRelease,
                    Description = dto.Description,
                    Title = dto.Title
                });

                _context.SaveChanges();

                return new ResultDTO
                {
                    Code = 200,
                    Message = "OK"
                };
            }
            catch (Exception e)
            {

                return new ResultDTO
                {
                    Code = 500,
                    Message = e.Message
                };
            }
        }

        [HttpPut("editNews/{idNews}")]
        public ResultDTO editNews([FromRoute]int idNews, [FromBody]CreateNewsDTO dto)
        {
            try
            {
                var current_news = _context.News.FirstOrDefault(t => t.Id == idNews);
                current_news.Title = dto.Title;
                current_news.Description = dto.Description;
                current_news.Author = dto.Author;
                current_news.DateRelease = dto.DateRelease;

                _context.SaveChanges();
                return new ResultDTO
                {
                    Code = 200,
                    Message = "OK"
                };
            }
            catch (Exception e)
            {
                return new ResultDTO
                {
                    Code = 500,
                    Message = e.Message
                };
            }
        }

        //[HttpGet] <- відправляємо запрос з id елементу для видалення
        //[HttpDelete] <- відправляти обєкт для видалення

        [HttpGet("removeNews/{idNews}")]
        public ResultDTO removeNews([FromRoute]int idNews)
        {
            try
            {
                var removeNews = _context.News.FirstOrDefault(t => t.Id == idNews);
                _context.News.Remove(removeNews);
                _context.SaveChanges();

                return new ResultDTO
                {
                    Code = 200,
                    Message = "OK"
                };
            }
            catch (Exception e)
            {
                return new ResultDTO
                {
                    Code = 500,
                    Message = e.Message
                };
            }
        }

        //GET: locahost:1233/api/News/search?q=it
        [HttpGet("search")]
        public List<NewsDTO> search([FromQuery]string q)
        {
            var data = _context.News.Where(t => t.Title.Contains(q)).Select(t => new NewsDTO
            {
                Title = t.Title,
                Author = t.Author,
                DateRelease = t.DateRelease,
                Description = t.Description,
                Id = t.Id
            }).ToList();
            return data;
        }

    }
}