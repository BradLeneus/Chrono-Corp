using ChronoCorp.Interface;
using ChronoCorp.Model;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace ChronoCorp.Service
{
    public class AuthService : IAuthService
    {
        private readonly string _connectionString = "server=localhost;user=root;password=;database=chronocorp;";

        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            using var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();

            var cmd = new MySqlCommand("SELECT COUNT(*) FROM employee_credentials WHERE username = @username AND mdp = @mdp", connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@mdp", password);

            var result = (long)await cmd.ExecuteScalarAsync();
            return result > 0;
        }

        public async Task<long> GetEmployeeIdAsync(string username, string password)
        {
            using var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();

            var cmd = new MySqlCommand("SELECT id FROM employee_credentials WHERE username = @username AND mdp = @mdp", connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@mdp", password);

            var result = (long)await cmd.ExecuteScalarAsync();
            return result;
        }

        public async Task<String> GetEmployeeRoleAsync(string username, string password)
        {
            using var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();

            var cmd = new MySqlCommand("SELECT role FROM employee_credentials WHERE username = @username AND mdp = @mdp", connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@mdp", password);

            return (string)await cmd.ExecuteScalarAsync();
        }
    }
}

