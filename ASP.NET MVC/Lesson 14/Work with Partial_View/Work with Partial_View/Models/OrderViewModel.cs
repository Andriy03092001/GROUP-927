using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Work_with_Partial_View.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public float Price { get; set; }
        public string Address { get; set; }
        public string NameProduct { get; set; }
        public int CountProducts { get; set; }
    }

    
}