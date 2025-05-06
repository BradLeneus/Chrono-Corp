namespace ChronoCorp.Model
{
    public class CedulePointage
    {
        public long Id { get; set; }
        public long IdEmployee { get; set; }
        public DateTime HeureDebut { get; set; }
        public DateTime HeureFin { get; set; }
        public bool IsPause { get; set; }
    }
}
