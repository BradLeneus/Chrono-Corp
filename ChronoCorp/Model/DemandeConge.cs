using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChronoCorp.Model
{
    public class DemandeConge
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("Employee")]
        public long IdEmetteur { get; set; }
        [ForeignKey("Gestionnaire")]
        public long IdDestinataire { get; set; }
        public DateTime TempsSoumission { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        [ForeignKey("TypeQuarts")]
        public required int TypeQuart { get; set; }
        public required string Commentaire { get; set; }
        public string? Reponse { get; set; }
        public bool? EstApprouve { get; set; }
        public DateTime? TempsModif { get; set; }

        public TypeQuart TypeQuarts { get; set; }

        public Employee Employee { get; set; }
        public Employee Gestionnaire { get; set; }
    }
}
