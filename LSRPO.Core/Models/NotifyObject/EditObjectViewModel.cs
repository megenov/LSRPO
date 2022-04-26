using System.ComponentModel.DataAnnotations;

namespace LSRPO.Core.Models.NotifyObject
{
    public class EditObjectViewModel
    {
        public int ObjectId { get; set; }

        [Required(ErrorMessage = "Полето {0} е задължително")]
        [StringLength(200, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        [Display(Name = "Име")]
        public string? Name { get; set; }

        //[Required(ErrorMessage = "Полето {0} е задължително")]
        //[StringLength(20, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
        [RegularExpression(@"^[8]{1}[\d]{3}$|^[0]{2}[\d]{9}$", ErrorMessage = "Номерът за обекти трябва да бъде от 4 цифри и започващ с 8. За лица да бъде от 11 цифри и започващ с 00.")]
        [Display(Name = "Телефон 1")]
        public string? Phone1 { get; set; }

        //[StringLength(20, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
        [RegularExpression(@"^[0]{2}[\d]{9}$", ErrorMessage = "Номерът трябва да бъде от 11 цифри и започващ с 00.")]
        [Display(Name = "Телефон 2")]
        public string? Phone2 { get; set; }

        [StringLength(20, ErrorMessage = "Номерът трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
        [Display(Name = "Телефон 3")]
        public string? Phone3 { get; set; }

        [StringLength(20, ErrorMessage = "Номерът трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
        [Display(Name = "Телефон 4")]
        public string? Phone4 { get; set; }

        [Required(ErrorMessage = "Полето {0} е задължително")]
        [Display(Name = "Тип")]
        public byte? TypeId { get; set; }
    }
}