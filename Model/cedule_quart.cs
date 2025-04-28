using System;
using System.Collections.Generic;

namespace ChronoCorp.Models
{
    public class cedule_quart
    {
        public int id { get; set; }
        public int id_employee { get; set; }
        public int id_createur { get; set; }
        public DateTime heure_debut { get; set; }
        public DateTime heure_fin { get; set; }

        // Navigation properties
        public virtual employee employee { get; set; }
        public virtual employee createur { get; set; }
        public virtual ICollection<cedule_pause> pauses { get; set; }
    }
}
