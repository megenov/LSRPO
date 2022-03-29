using System.ComponentModel.DataAnnotations;

namespace LSRPO.Core.Models.NotifyProcess
{
    public class EditProcessTypeViewModel
    {
        [Display(Name = "ID на тип процес")]
        public int ProcessTypeId { get; set; }

        [Required(ErrorMessage = "Полето {0} е задължително")]
        [StringLength(100, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        [Display(Name = "Описание")]
        public string? Description { get; set; }
    }
}