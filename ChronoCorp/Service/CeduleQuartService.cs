using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoCorp.Service
{
    public class CeduleQuartService : ICeduleQuartService
    {
        private readonly ApplicationDbContext _dbContext;

        public CeduleQuartService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CeduleQuart>> GetAllCeduleQuartAsync()
        {
            return await _dbContext.Cedule_Quart.ToListAsync();
        }

        public async Task<List<CeduleQuart>> GetQuartListByEmployeeId(long id)
        {
            return await _dbContext.Cedule_Quart.Where(cd => cd.IdEmployee == id).ToListAsync();
        }

        public async Task AddCeduleQuartAsync(CeduleQuart quart)
        {

            // Vérifie que l'employé existe dans la table Employee
            bool employeeExiste = await _dbContext.Employee.AnyAsync(e => e.Id == quart.IdEmployee);
            if (!employeeExiste)
                throw new ArgumentException("L'employé spécifié n'existe pas dans la table Employee.");

            // Vérifie que le TypeQuart existe dans la table Type_Quart
            bool typeQuartExiste = await _dbContext.Type_Quart.AnyAsync(t => t.Id == quart.TypeQuart);
            if (!typeQuartExiste)
                throw new ArgumentException("Le TypeQuart spécifié n'existe pas dans la table Type_Quart.");

            await _dbContext.Cedule_Quart.AddAsync(quart);
            await _dbContext.SaveChangesAsync();
        }
    }
}