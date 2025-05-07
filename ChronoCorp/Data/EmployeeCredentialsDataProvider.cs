using ChronoCorp.Model;

namespace ChronoCorp.Data
{
    public interface IEmployeeCredentialsDataProvider
    {
        public Task<IEnumerable<EmployeeCredentials>?> GetAllEmployeesAsync();
    }
    public class EmployeeCredentialsDataProvider : IEmployeeCredentialsDataProvider
    {
        public async Task<IEnumerable<EmployeeCredentials>?> GetAllEmployeesAsync()
        {
            await Task.Delay(500);

            var employeeCreds = new List<EmployeeCredentials>
            {
                new EmployeeCredentials{ Id = 330201, Mdp = "Amalee123", Role = "Gestionnaire"},
                new EmployeeCredentials{ Id = 431999, Mdp = "Hadlee123", Role = "Gestionnaire"},
                new EmployeeCredentials{ Id = 432401, Mdp = "Nona123", Role = "Employé"},
                new EmployeeCredentials{ Id = 433753, Mdp = "Lila123", Role = "Employé"},
                new EmployeeCredentials{ Id = 434212, Mdp = "Adrian123", Role = "Employé"},
                new EmployeeCredentials{ Id = 435377, Mdp = "Esteban123", Role = "Gestionnaire"},
                new EmployeeCredentials{ Id = 436222, Mdp = "Darrel123", Role = "Employé"},
                new EmployeeCredentials{ Id = 437745, Mdp = "Valina123", Role = "Employé"},
                new EmployeeCredentials{ Id = 438412, Mdp = "Karel123", Role = "Ressources humaines"},
                new EmployeeCredentials{ Id = 439204, Mdp = "Ferdinande123", Role = "Employé"}
            };

            return employeeCreds;
        }
    }
}
