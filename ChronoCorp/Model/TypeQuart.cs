namespace ChronoCorp.Model
{
    public class TypeQuart
    {
        public long Id { get; set; }
        public string Nom { get; set; }
        public string Code { get; set; }
        public bool EstConge { get; set; }
        public float TauxMajoration { get; set; }
        public string? Description { get; set; }
    }
}
