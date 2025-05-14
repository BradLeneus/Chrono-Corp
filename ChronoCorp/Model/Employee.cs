using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChronoCorp.Model
{
    public class Employee
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("Gestionnaire")]
        public long? IdSuperieur { get; set; }
        public required string Prenom { get; set; }
        public required string Nom { get; set; }
        public required string Courriel { get; set; }
        public string? AdresseLigne1 { get; set; }
        public string? AdresseLigne2 { get; set; }
        public string? Ville { get; set; }
        public string? CodePostal { get; set; }
        public required string Telephone { get; set; }
        public DateTime DateNaissance { get; set; }
        public string? ContactUrgenceTel { get; set; }
        public string? ContactUrgenceNom { get; set; }
        public DateTime DateEmbauche { get; set; }
        public required string Departement { get; set; }
        public required string Poste { get; set; }
        public float Salaire { get; set; }
        public bool EstActif { get; set; }
        public float? ArgentGagneTotal { get; set; }
        public float? NbrHeureTotal { get; set; }
        public float? NbrHeureConge { get; set; }

        public Employee Gestionnaire { get; set; }

        public string NomComplet 
        {
            get { return $"{Prenom} {Nom}"; }
        }

        public EmployeeCredentials employeeCredentials { get; set; }
        public ICollection<CeduleQuart> CeduleQuartsEmp { get; set; }
        public ICollection<CeduleQuart> CeduleQuartsGest { get; set; }
        public ICollection<DemandeConge> DemandeConges { get; set; }
        public ICollection<DemandeConge> ApprobationConges { get; set; }
        public ICollection<FichePaie> FichePaies { get; set; }
        public ICollection<Messagerie> MessagerieSender { get; set; }
        public ICollection<Messagerie> MessagerieReceiver { get; set; }
    }
}
