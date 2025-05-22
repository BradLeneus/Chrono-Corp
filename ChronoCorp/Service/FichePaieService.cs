using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChronoCorp.Service
{
    public class FichePaieService : IFichePaieService
    {
        private readonly ApplicationDbContext _dbContext;

        public FichePaieService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<FichePaie>> GetFichePaieListByEmployeeId(long id)
        {
            return await _dbContext.Fiche_Paie.Where(fp => fp.IdEmployee == id).ToListAsync();
        }

        public async Task InsererFichePaieAsync(FichePaie fichePaie)
        {
            _dbContext.Fiche_Paie.Add(fichePaie);
            await _dbContext.SaveChangesAsync();
        }
    }
}
