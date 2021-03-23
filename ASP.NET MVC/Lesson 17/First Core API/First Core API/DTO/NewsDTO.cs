using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace First_Core_API.DTO
{
    public class NewsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DateRelease { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }

    public class CreateNewsDTO
    {
        [Required(ErrorMessage = "Title is required field")]
        [StringLength(maximumLength: 5, ErrorMessage = "Title max lenght 5 chars")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Date release is required field")]
        public string DateRelease { get; set; }

        [Required(ErrorMessage = "Description is required field")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Author is required field")]
        public string Author { get; set; }
    }
}
