using System.ComponentModel.DataAnnotations;

namespace LSRPO.Core.Models.User
{
    public class UserEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Полето {0} е задължително")]
        [StringLength(100, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
        [Display(Name = "Име")]
        public string? FullName { get; set; }
    }
}