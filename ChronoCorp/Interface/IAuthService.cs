using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoCorp.Interface
{
    public interface IAuthService
    {
        Task<bool> AuthenticateAsync(int id, string password);
        Task<string> GetEmployeeRoleAsync(int id, string password);
    }
}
