using System.ComponentModel.DataAnnotations;

namespace LSRPO.Core.Models.NotifyObject
{
    public class AddObjectViewModel
    {
        [Required(ErrorMessage = "Полето {0} е задължително")]
        [StringLength(200, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        [RegularExpression(@"^[A-ZА-Я0-9]+( [A-ZА-Я0-9]+)*$", ErrorMessage = "Полето {0} трябва да съдържа само главни букви, цифри и интервал")]
        [Display(Name = "Име")]
        public string? Name { get; set; }

        //[Required(ErrorMessage = "Полето {0} е задължително")]
        //[StringLength(20, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
        [RegularExpression(@"^[8]{1}[\d]{3}$|^[0]{2}[\d]{9}$", ErrorMessage = "Номерът за обекти трябва да бъде от 4 цифри и започващ с 8. За лица да бъде от 11 цифри и започващ с 00.")]
        [Display(Name = "Тел. Обект / Мобилен 1")]
        public string? Phone1 { get; set; }

        //[StringLength(20, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
        [RegularExpression(@"^[0]{2}[\d]{9}$", ErrorMessage = "Номерът трябва да бъде от 11 цифри и започващ с 00.")]
        [Display(Name = "Мобилен 2")]
        public string? Phone2 { get; set; }

        [StringLength(20, ErrorMessage = "Номерът трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
        [Display(Name = "Служебен 1")]
        public string? Phone3 { get; set; }

        [StringLength(20, ErrorMessage = "Номерът трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
        [Display(Name = "Служебен 2")]
        public string? Phone4 { get; set; }

        [Required(ErrorMessage = "Полето {0} е задължително")]
        [Display(Name = "Тип")]
        public byte? TypeId { get; set; }

        [Display(Name = "Пост")]
        public int? PositionId { get; set; }
    }
}