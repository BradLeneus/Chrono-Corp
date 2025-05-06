namespace ChronoCorp.Model
{
    public class DemandeConge
    {
        public long Id { get; set; }
        public long IdEmetteur { get; set; }
        public long IdDestinataire { get; set; }
        public DateTime TempsSoumission { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int TypeQuart { get; set; }
        public string Commentaire { get; set; }
        public string? Reponse { get; set; }
        public bool? EstApprouve { get; set; }
        public DateTime? TempsModif { get; set; }
    }
}
