using System;

namespace ChronoCorp.Models
{
    public class cedule_pointage
    {
        public int id { get; set; }
        public int id_employee { get; set; }
        public DateTime heure_debut { get; set; }
        public DateTime heure_fin { get; set; }

        // Navigation property
        public virtual employee employee { get; set; }
    }
}
