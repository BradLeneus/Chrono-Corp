using System;

namespace ChronoCorp.Models
{
    public class cedule_pause
    {
        public int id { get; set; }
        public int id_quart { get; set; }
        public DateTime heure_debut { get; set; }
        public DateTime heure_fin { get; set; }
        public bool est_payee { get; set; }

        // Navigation property
        public virtual cedule_quart quart { get; set; }
    }
}
