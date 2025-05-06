namespace ChronoCorp.Model
{
    public class FichePaie
    {
        public long Id { get; set; }
        public long IdEmployee { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public float Montant { get; set; }
        public float NbrHeure { get; set; }
        public float VacanceCumul { get; set; }
        public DateTime DatePaie { get; set; }
    }
}
