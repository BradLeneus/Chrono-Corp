using System;

namespace ChronoCorp.Models
{
    public class demande_conge
    {
        public int id { get; set; }
        public int id_emetteur { get; set; }
        public int id_destinataire { get; set; }
        public DateTime temps_soumission { get; set; }
        public DateTime date_debut { get; set; }
        public DateTime date_fin { get; set; }
        public string type { get; set; }
        public string commentaire { get; set; }
        public string reponse { get; set; }
        public bool est_approuve { get; set; }
        public DateTime? temps_modif { get; set; }

        // Navigation properties
        public virtual employee emetteur { get; set; }
        public virtual employee destinataire { get; set; }
    }
}
