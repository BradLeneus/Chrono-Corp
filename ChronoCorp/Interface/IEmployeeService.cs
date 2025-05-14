using ChronoCorp.Model;

namespace ChronoCorp.Interface
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(long userId);

        Task<List<Employee>> GetEmployeeListByIdSuperiorAsync(long superiorId);

        Task AddNewEmployeeAsync(Employee employee);

        // Task UpdateEmployeeAsync(Employee employee);
    }
}
