namespace ChronoCorp.Model
{
    public class Employee
    {
        public long Id { get; set; }
        public int? IdSuperieur { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string? Courriel { get; set; }
        public string? AdresseLigne1 { get; set; }
        public string? AdresseLigne2 { get; set; }
        public string? Ville { get; set; }
        public string? CodePostal { get; set; }
        public string? Telephone { get; set; }
        public DateTime DateNaissance { get; set; }
        public string? ContactUrgenceTel { get; set; }
        public string? ContactUrgenceNom { get; set; }
        public DateTime DateEmbauche { get; set; }
        public string? Departement { get; set; }
        public string Poste { get; set; }
        public float Salaire { get; set; }
        public bool EstActif { get; set; }
        public float? ArgentGagneTotal { get; set; }
        public float? NbrHeureTotal { get; set; }
        public float? NbrHeureConge { get; set; }
    }
}
