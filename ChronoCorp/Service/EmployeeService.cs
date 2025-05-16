using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Model;
using Microsoft.EntityFrameworkCore;

namespace ChronoCorp.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeService()
        {
            _dbContext = new ApplicationDbContext();
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _dbContext.Employee.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(long id)
        {
            var employee = await _dbContext.Employee.FirstOrDefaultAsync(emp => emp.Id == id);
            if (employee == null)
            {
                throw new InvalidOperationException($"Employee with ID {id} not found.");
            }
            return employee;
        }

        public async Task<List<Employee>> GetEmployeeListByIdSuperiorAsync(long id)
        {
            return await _dbContext.Employee.Where(emp => emp.IdSuperieur == id).ToListAsync();
        }

        public async Task AddNewEmployeeAsync(Employee employee)
        {
            _dbContext.Employee.Add(employee);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            _dbContext.Employee.Update(employee);
            await _dbContext.SaveChangesAsync();
        }
    }
}
