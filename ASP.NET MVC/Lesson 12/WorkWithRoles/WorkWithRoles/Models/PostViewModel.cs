using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkWithRoles.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string DateRelease { get; set; }
        public string Author { get; set; }
    }
}