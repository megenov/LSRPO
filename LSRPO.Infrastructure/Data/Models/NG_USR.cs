using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSRPO.Infrastructure.Data.Models
{
    public class NG_USR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NG_USR_ID { get; set; }

        [ForeignKey(nameof(NOTIFY_GROUP))]
        public int? NG_ID { get; set; }
        public NOTIFY_GROUP NOTIFY_GROUP { get; set; }

        [ForeignKey(nameof(AUTH_USER))]
        public int? USR_ID { get; set; }
        public AUTH_USER AUTH_USER { get; set; }
    }
}