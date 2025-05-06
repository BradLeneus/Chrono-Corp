namespace ChronoCorp.Model
{
    public class CeduleQuart
    {
        public long Id { get; set; }
        public long IdEmployee { get; set; }
        public long IdCreateur { get; set; }
        public int TypeQuart { get; set; }
        public DateTime HeureDebut { get; set; }
        public DateTime HeureFin { get; set; }
    }
}
