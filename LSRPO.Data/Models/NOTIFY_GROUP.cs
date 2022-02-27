using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSRPO.Data.Models
{
    public class NOTIFY_GROUP
    {
        public NOTIFY_GROUP()
        {
            NG_USRS = new HashSet<NG_USR>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NG_ID { get; set; }

        public DateTime? NG_REG_DATE { get; set; }

        [Required]
        [StringLength(20)]
        public string NG_NAME { get; set; }

        [StringLength(400)]
        public string NG_DESCRIPTION { get; set; }

        [StringLength(20)]
        public string NG_NUMBER { get; set; }

        public bool? NG_MOD_FLAG { get; set; }

        public ICollection<NG_USR> NG_USRS { get; set; }
    }
}