using ChronoCorp.Data;
using ChronoCorp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
