using System.ComponentModel.DataAnnotations;

namespace LSRPO.Core.Models.User
{
    public class ChangePinViewModel
    {
        public int? UserId { get; set; }

        public string? UserName { get; set; }

        //[StringLength(6, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
        [Required(ErrorMessage = "Полето {0} е задължително")]
        [RegularExpression(@"^[\d*\**\#*]{6}$", ErrorMessage = "Полето трябва да бъде точно 6 символа. Разрешени символи: 0-9, *, #")]
        [Display(Name = "ПИН код")]
        public string? PinCode { get; set; }
    }
}