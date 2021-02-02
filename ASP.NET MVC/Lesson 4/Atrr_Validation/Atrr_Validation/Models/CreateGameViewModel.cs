using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atrr_Validation.Models
{
    public class CreateGameViewModel
    {
        [Required(ErrorMessage = "Це поле э обов'язковим")]
        [StringLength(maximumLength:100, ErrorMessage = "Максимальна довжина цього поля э 100 символів")]
        [DisplayName("Name: ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Це поле э обов'язковим")]
        [DisplayName("Developer: ")]
        [StringLength(maximumLength: 100, ErrorMessage = "Максимальна довжина цього поля э 100 символів")]
        public string Developer { get; set; }

        [Required(ErrorMessage = "Це поле э обов'язковим")]
        [Range(0, 100,ErrorMessage = "Мінімальна ціна 0$ а максимальна 100;")]
        [DataType(DataType.Currency)]
        [DisplayName("Price: ")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Це поле э обов'язковим")]
        [StringLength(maximumLength:500, ErrorMessage = "Максимальна довжина цього поля э 500 символів")]
        [DataType(DataType.MultilineText)]
        [DisplayName("Description: ")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Це поле э обов'язковим")]
        [DataType(DataType.Date)]
        [DisplayName("Date release: ")]
        public string DateRelease { get; set; }

        [Required(ErrorMessage = "Це поле э обов'язковим")]
        [DataType(DataType.ImageUrl)]
        [DisplayName("Image URL: ")]
        public string URL_Image { get; set; }
    }
}