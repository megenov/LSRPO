using System.ComponentModel.DataAnnotations;

namespace LSRPO.Core.Models.NotifyObject
{
    public class EditPultViewModel
    {
        public int PultId { get; set; }

        [Required(ErrorMessage = "Полето {0} е задължително")]
        [StringLength(100, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        [Display(Name = "Име")]
        public string? Name { get; set; }

        [StringLength(100, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        [Display(Name = "Описание")]
        public string? Description { get; set; }

        [StringLength(20, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        [Display(Name = "Номер")]
        public string? Number { get; set; }

        [RegularExpression(@"^((25[0-5]|(2[0-4]|1\d|[1-9]|)\d)(\.(?!$)|$)){4}$", ErrorMessage = "Полето трябва да съдържа валиден IP адрес!")]
        [Display(Name = "IP Адрес")]
        public string? Ip { get; set; }
    }
}