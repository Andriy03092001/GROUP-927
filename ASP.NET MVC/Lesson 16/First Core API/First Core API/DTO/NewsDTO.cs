using System;
using System.Collections.Generic;
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
        public string Title { get; set; }
        public string DateRelease { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
