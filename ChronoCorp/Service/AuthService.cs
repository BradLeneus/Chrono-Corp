using ChronoCorp.Model;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace ChronoCorp.Services
{
    public class AuthService
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
    }
}

