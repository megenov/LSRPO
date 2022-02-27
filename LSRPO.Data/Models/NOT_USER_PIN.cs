using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSRPO.Data.Models
{
    public class NOT_USER_PIN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NOT_USR_ID { get; set; }

        [StringLength(6)]
        public string USR_PIN { get; set; }

        //[ForeignKey(nameof(AUTH_USER))]
        public int? USR_ID { get; set; }
        public AUTH_USER AUTH_USER { get; set; }
    }
}