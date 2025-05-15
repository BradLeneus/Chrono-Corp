using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Model;
using Microsoft.EntityFrameworkCore;

namespace ChronoCorp.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
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
    }
}
