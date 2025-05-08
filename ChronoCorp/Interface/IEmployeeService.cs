using ChronoCorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ChronoCorp.Interface
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(long userId);

        Task<List<Employee>> GetEmployeeListByIdSuperiorAsync(long superiorId);
    }
}
