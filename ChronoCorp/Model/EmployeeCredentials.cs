using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChronoCorp.Model
{
    public class EmployeeCredentials
    {
        [Key, ForeignKey("Employee")]
        public long Id { get; set; }
        public required string Mdp { get; set; }
        public required string Role { get; set; }

        public Employee Employee { get; set; }
    }
}
