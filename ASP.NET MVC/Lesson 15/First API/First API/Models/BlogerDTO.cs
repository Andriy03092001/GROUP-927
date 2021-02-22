using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First_API.Models
{
    public class BlogerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountSubscribers { get; set; }
        public string Platform { get; set; }
        public int AgeAudience { get; set; }
        public string CategoryContent { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

    public class BlogerShortDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountSubscribers { get; set; }
        public string Image { get; set; }
    }


    public class CreateBlogerDTO
    {
        public string Name { get; set; }
        public int CountSubscribers { get; set; }
        public string Platform { get; set; }
        public int AgeAudience { get; set; }
        public string CategoryContent { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}