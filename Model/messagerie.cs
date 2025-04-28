using System;

namespace ChronoCorp.Models
{
    public class messagerie
    {
        public int id { get; set; }
        public int id_emetteur { get; set; }
        public int id_destinataire { get; set; }
        public string titre { get; set; }
        public string contenu { get; set; }
        public byte[] fichier { get; set; }
        public DateTime temps { get; set; }
        public bool est_lu { get; set; }

        // Navigation properties
        public virtual employee emetteur { get; set; }
        public virtual employee destinataire { get; set; }
    }
}
