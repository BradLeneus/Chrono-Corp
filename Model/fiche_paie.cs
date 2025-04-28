using System;

namespace ChronoCorp.Models
{
    public class fiche_paie
    {
        public int id { get; set; }
        public int id_employee { get; set; }
        public DateTime debut_periode { get; set; }
        public DateTime fin_periode { get; set; }
        public float montant { get; set; }
        public DateTime date_paie { get; set; }

        // Navigation property
        public virtual employee employee { get; set; }
    }
}
