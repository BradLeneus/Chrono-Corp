using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Model;
using Microsoft.EntityFrameworkCore;

namespace ChronoCorp.Service
{
    public class TypeQuartService : ITypeQuartService
    {
        private readonly ApplicationDbContext _dbContext;

        public TypeQuartService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<TypeQuart>> GetAllTypeQuartAsync()
        {
            return await _dbContext.Type_Quart.ToListAsync();
        }
    }
}
