using First_API.Entity;
using First_API.Models;
using First_API.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace First_API.Controllers
{

    [RoutePrefix("api/Blogers")]
    public class BlogersController : ApiController
    {

        private EFContext _context;

        public BlogersController()
        {
            _context = new EFContext();
        }

        //GET: localhost:12333/api/Blogers/
        [HttpGet]
        [Route("getBlogers")]
        public List<BlogerDTO> getBlogers()
        {
            var data = _context.Blogers.Select(t => new BlogerDTO
            {
                AgeAudience = t.AgeAudience,
                CategoryContent = t.CategoryContent,
                CountSubscribers = t.CountSubscribers,
                Description = t.Description,
                Id = t.Id,
                Image = t.Image,
                Name = t.Name,
                Platform = t.Platform
            }).ToList();

            return data;
        }

        [HttpGet]
        [Route("getShortBlogers")]
        public List<BlogerShortDTO> getShortBlogers()
        {
            var data = _context.Blogers.Select(t => new BlogerShortDTO
            {
                CountSubscribers = t.CountSubscribers,
                Id = t.Id,
                Image = t.Image,
                Name = t.Name,
            }).ToList();

            return data;
        }

        [HttpPost]
        public ResultDTO Create([FromBody]CreateBlogerDTO dto)
        {
            try
            {
                _context.Blogers.Add(new Bloger()
                {
                    AgeAudience = dto.AgeAudience,
                    CategoryContent = dto.CategoryContent,
                    CountSubscribers = dto.CountSubscribers,
                    Description = dto.Description,
                    Image = dto.Image,
                    Name = dto.Name,
                    Platform = dto.Platform
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
                    Message = e.Message,
                    Code = 500
                };
            }
          
        }

        [HttpGet]
        [Route("getBloger/{Id}")]
        public BlogerDTO getBloger(int Id)
        {
            var t = _context.Blogers.FirstOrDefault(q => q.Id == Id);
            var bloger = new BlogerDTO
            {
                AgeAudience = t.AgeAudience,
                CategoryContent = t.CategoryContent,
                CountSubscribers = t.CountSubscribers,
                Description = t.Description,
                Id = t.Id,
                Image = t.Image,
                Name = t.Name,
                Platform = t.Platform
            };

            return bloger;
        }





    }
}
