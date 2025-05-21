using System.ComponentModel.DataAnnotations;

namespace ChronoCorp.Model
{
    public class TypeQuart
    {
        [Key]
        public int Id { get; set; }
        public required string Nom { get; set; }
        public required string Code { get; set; }
        public bool EstConge { get; set; }
        public float TauxMajoration { get; set; }
        public string? Description { get; set; }

        public ICollection<DemandeConge> DemandesConges { get; set; }
        public ICollection<CeduleQuart> CeduleQuarts { get; set; }
    }
}
