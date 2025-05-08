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
        //public async Task<List<CeduleQuart>> GetCeduleQuartListByCreatorId(long id)
        //{
        //    var cedules = await _provider.GetAllCeduleQuartAsync();
        //    return cedules.Where(cedule => cedule.IdCreateur == id).ToList();
        //}

        //// ajouter date deb, date fin
        //public async Task<List<CeduleQuart>> GetCeduleQuartListByEmployeeId(long id)
        //{
        //    var cedules = await _provider.GetAllCeduleQuartAsync();
        //    return cedules.Where(cedule => cedule.IdEmployee == id).ToList();
        //}
    }
}
