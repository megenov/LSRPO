using System.ComponentModel.DataAnnotations;

namespace LSRPO.Core.Models.NotifyGroup
{
    public class EditGroupViewModel
    {
        public int GroupId { get; set; }

        [Required(ErrorMessage = "Полето {0} е задължително")]
        [StringLength(20, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        [Display(Name = "Име")]
        public string? Name { get; set; }

        [StringLength(400, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        [Display(Name = "Описание")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Полето {0} е задължително")]
        [StringLength(20, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        [Display(Name = "Номер")]
        public string? Number { get; set; }
    }
}