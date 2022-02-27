using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSRPO.Data.Models
{
    public class NG_NP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NGNP_ID { get; set; }

        [Required]
        [ForeignKey(nameof(NOTIFY_GROUP))]
        public int NG_ID { get; set; }
        public NOTIFY_GROUP NOTIFY_GROUP { get; set; }

        [Required]
        [ForeignKey(nameof(NOTIFY_OBJECT))]
        public int NO_ID { get; set; }
        public NOTIFY_OBJECT NOTIFY_OBJECT { get; set; }
    }
}