using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project__DrobDownList_.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public List<SelectListItem> Genders { get; set; }
        //public Gender studentGender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}