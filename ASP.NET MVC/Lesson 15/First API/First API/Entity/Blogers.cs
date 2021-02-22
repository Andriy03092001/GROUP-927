using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace First_API.Entity
{
    [Table("tblBlogers")]
    public class Bloger
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CountSubscribers { get; set; }
        [Required]
        public string Platform { get; set; }
        [Required]
        public int AgeAudience { get; set; }
        [Required]
        public string CategoryContent { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
    }
}