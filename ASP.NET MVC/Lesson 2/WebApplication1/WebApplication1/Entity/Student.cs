using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Entity
{
    [Table("tblStudent")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string FullName { get; set; }
        
        [Required]
        public int Age { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        [Required]
        public string URL_Image { get; set; }

    }
}

