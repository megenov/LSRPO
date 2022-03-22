using System.ComponentModel.DataAnnotations;

namespace LSRPO.Core.Models.User
{
    public class UserProfileViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Потребителско име")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Полето {0} е задължително")]
        [StringLength(100, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
        [Display(Name = "Име")]
        public string? FullName { get; set; }

        //[Display(Name = "Снимка")]
        //[StringLength(200, ErrorMessage = "Полето {0} не може да надвишава {1} символа.")]
        //public string? Image { get; set; }
    }
}