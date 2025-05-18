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
    public class DemandeCongeService : IDemandeCongeService
    {
        private readonly ApplicationDbContext _dbContext;

        public DemandeCongeService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<DemandeConge>> GetDemandeCongeListByIdDestinataire(long id)
        {
            return await _dbContext.Demande_Conge.Where(dc => dc.IdDestinataire == id).ToListAsync();
        }

        public async Task<List<DemandeConge>> GetDemandeCongeListByIdEmetteur(long id)
        {
            return await _dbContext.Demande_Conge.Where(dc => dc.IdEmetteur == id).ToListAsync();

        }
        public async Task AddDemandeCongeAsync(DemandeConge demande)
        {
            _dbContext.Demande_Conge.Add(demande);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateDemandeCongeAsync(DemandeConge demande)
        {
            _dbContext.Demande_Conge.Update(demande);
            await _dbContext.SaveChangesAsync();
        }
    }
}
