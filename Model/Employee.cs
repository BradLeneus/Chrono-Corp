using System;
using System.Collections.Generic;

namespace ChronoCorp.Models
{
    public class employee
    {
        public int id { get; set; }
        public int? id_superieur { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }
        public string courriel { get; set; }
        public string adresse_ligne1 { get; set; }
        public string adresse_ligne2 { get; set; }
        public string ville { get; set; }
        public string code_postal { get; set; }
        public string telephone { get; set; }
        public DateTime date_naissance { get; set; }
        public string contact_urgence_tel { get; set; }
        public string contact_urgence_nom { get; set; }
        public DateTime date_embauche { get; set; }
        public string departement { get; set; }
        public string poste { get; set; }
        public float salaire { get; set; }
        public bool est_actif { get; set; }

        // Navigation properties
        public virtual employee superieur { get; set; }
        public virtual ICollection<employee> subordonnes { get; set; }
        public virtual employee_credentials credentials { get; set; }
        public virtual ICollection<cedule_quart> quarts { get; set; }
        public virtual ICollection<cedule_pointage> pointages { get; set; }
        public virtual ICollection<demande_conge> demandes_envoyees { get; set; }
        public virtual ICollection<demande_conge> demandes_recues { get; set; }
        public virtual ICollection<messagerie> messages_envoyes { get; set; }
        public virtual ICollection<messagerie> messages_recus { get; set; }
        public virtual ICollection<fiche_paie> fiches_paie { get; set; }
    }
}
