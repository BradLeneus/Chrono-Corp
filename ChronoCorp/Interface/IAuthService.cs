using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoCorp.Interface
{
    public interface IAuthService
    {
        Task<bool> AuthenticateAsync(string username, string password);
        Task<long> GetEmployeeIdAsync(string username, string password);
        Task<string> GetEmployeeRoleAsync(string username, string password);
    }
}
