using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkWithRoles.Areas.Admin.Models
{
    public class CreatePostViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string DateRelease { get; set; }

        [Required]
        public string Author { get; set; }
    }
}
//Enable-migrations
//Add-migration "ffff"
//Update-database