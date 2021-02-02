using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atrr_Validation.Models
{
    public class GameViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string DateRelease { get; set; }
        public string URL_Image { get; set; }
    }
}