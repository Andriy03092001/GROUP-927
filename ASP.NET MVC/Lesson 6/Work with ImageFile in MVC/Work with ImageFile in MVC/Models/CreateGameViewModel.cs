using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Work_with_ImageFile_in_MVC.Models
{
    public class CreateGameViewModel
    {
        [Required]
        [DisplayName("Name game:")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Price($):")]
        [Range(5, 100)]
        public float Price { get; set; }
        [Required]
        [DisplayName("Developer:")]
        public string Developer { get; set; }
        [Required]
        [DisplayName("Image file:")]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}