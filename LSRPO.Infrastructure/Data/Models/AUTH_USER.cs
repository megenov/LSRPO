using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LSRPO.Infrastructure.Data.Models
{
    public class AUTH_USER : IdentityUser<int>
    {
        public AUTH_USER()
        {
            NG_USRS = new HashSet<NG_USR>();
        }

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int USR_ID { get; set; }

        //[Required]
        //[StringLength(20)]
        //public string USR_USERNAME { get; set; }

        //[StringLength(100)]
        //public string? USR_EMAIL { get; set; }

        //[Required]
        //[StringLength(64)]
        //public string USR_PASSWORD { get; set; }

        [Required]
        [StringLength(100)]
        public string USR_FULLNAME { get; set; }

        [StringLength(200)]
        public string? IMAGE_URL { get; set; }

        public DateTime? USR_REG_DATE { get; set; }

        public NOT_USER_PIN NOT_USER_PIN { get; set; }

        public ICollection<NG_USR> NG_USRS { get; set; }
    }
}