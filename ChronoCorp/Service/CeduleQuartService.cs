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

        //// ajouter date deb, date fin
        public async Task<List<CeduleQuart>> GetQuartListByEmployeeId(long id)
        {
            return await _dbContext.Cedule_Quart.Where(cd => cd.IdEmployee == id).ToListAsync();
        }
    }
}
