using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManager.Models
{
    public class NewsViewModel
    {
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
    }

    public class CreateNewsViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string ImageURL { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string ReleaseDate { get; set; }
    }
}