using System.ComponentModel.DataAnnotations;

namespace LSRPO.Core.Models.User
{
    public class ChangePasswordViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Полето {0} е задължително")]
        [StringLength(100, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потвърждаване на паролата")]
        [Compare("Password", ErrorMessage = "Паролите не съвпадат")]
        public string ConfirmPassword { get; set; }
    }
}