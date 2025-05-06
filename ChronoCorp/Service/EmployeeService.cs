using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Model;

namespace ChronoCorp.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeDataProvider _provider;

        public EmployeeService(IEmployeeDataProvider provider)
        {
            _provider = provider;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _provider.GetAllEmployeesAsync();
        }

        public async Task<Employee?> GetEmployeeByIdAsync(long id)
        {
            var employees = await _provider.GetAllEmployeesAsync();
            return employees.Where(emp => emp.Id == id).FirstOrDefault();
        }

        public async Task<List<Employee>?> GetEmployeeListByIdSuperiorAsync(long id)
        {
            var employees = await _provider.GetAllEmployeesAsync();
            if (employees == null)
            {
                Console.WriteLine("Employee list from provider is null!");
                return null;
            }

            var result = employees.Where(emp => emp.IdSuperieur == id).ToList();

            Console.WriteLine($"Filtering for IdSuperieur = {id}, found {result.Count} employees");
            return result;
        }
    }
}
