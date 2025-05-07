using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChronoCorp.Model
{
    public class CedulePointage
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("Employee")]
        public long IdEmployee { get; set; }
        public DateTime HeureDebut { get; set; }
        public DateTime HeureFin { get; set; }

        public Employee Employee { get; set; }
    }
}
