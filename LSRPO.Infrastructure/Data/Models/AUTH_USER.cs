using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSRPO.Infrastructure.Data.Models
{
    public class AUTH_USER
    {
        public AUTH_USER()
        {
            NG_USRS = new HashSet<NG_USR>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int USR_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string USR_USERNAME { get; set; }

        public DateTime? USR_REG_DATE { get; set; }

        [Required]
        [StringLength(100)]
        public string USR_FULLNAME { get; set; }

        [StringLength(100)]
        public string? USR_EMAIL { get; set; }

        [Required]
        [StringLength(64)]
        public string USR_PASSWORD { get; set; }

        [StringLength(200)]
        public string? IMAGE_URL { get; set; }

        public NOT_USER_PIN NOT_USER_PIN { get; set; }

        public ICollection<NG_USR> NG_USRS { get; set; }
    }
}