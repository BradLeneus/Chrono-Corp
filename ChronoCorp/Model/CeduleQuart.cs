using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChronoCorp.Model
{
    public class CeduleQuart
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("Employee")]
        public long IdEmployee { get; set; }
        [ForeignKey("Gestionnaire")]
        public long IdCreateur { get; set; }
        [ForeignKey("TypeDuQuart")]
        public int TypeQuart { get; set; }
        public bool IsPausePayee { get; set; }
        public DateTime HeureDebut { get; set; }
        public DateTime HeureFin { get; set; }
        public DateTime? HeureEntree { get; set; }
        public DateTime? HeureDepart { get; set; }
        public bool IsPointageApprouve { get; set; }

        public Employee Employee { get; set; }
        public Employee Gestionnaire { get; set; }
        public TypeQuart TypeDuQuart { get; set; }
    }
}
