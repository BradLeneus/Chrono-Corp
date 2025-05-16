using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChronoCorp.Model
{
    public class Messagerie
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("Employee1")]
        public long IdEmetteur { get; set; }
        [ForeignKey("Employee2")]
        public long IdDestinataire { get; set; }
        public required string TypeMessage { get; set; }
        //public string Titre { get; set; }
        public required string Contenu { get; set; }
        //public byte[]? Fichier { get; set; }
        public DateTime Temps { get; set; }
        //public bool EstLu { get; set; }

        public Employee Employee1 { get; set; }
        public Employee Employee2 { get; set; }
    }
}
