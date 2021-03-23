using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace First_Core_API.Entity
{
    [Table("tblNews")]
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string DateRelease { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
    }
}
