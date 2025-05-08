using ChronoCorp.Data;
using ChronoCorp.Interface;

namespace ChronoCorp.Service
{
    public class TypeQuartService : ITypeQuartService
    {
        private readonly ApplicationDbContext _dbContext;

        public TypeQuartService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
