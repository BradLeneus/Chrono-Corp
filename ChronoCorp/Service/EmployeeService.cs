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

        public async Task<Employee?> GetEmployeeByIdAsync(long id)
        {
            return await _dbContext.Employee.FirstOrDefaultAsync(emp => emp.Id == id);
        }

        //public async Task<List<Employee>?> GetEmployeeListByIdSuperiorAsync(long id)
        //{
        //    var employees = await _dbContext.GetAllEmployeesAsync();
        //    if (employees == null)
        //    {
        //        Console.WriteLine("Employee list from provider is null!");
        //        return null;
        //    }

        //    var result = employees.Where(emp => emp.IdSuperieur == id).ToList();

        //    Console.WriteLine($"Filtering for IdSuperieur = {id}, found {result.Count} employees");
        //    return result;
        //}
    }
}
