using ChronoCorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoCorp.Interface
{
    public interface IFichePaieService
    {
        Task<List<FichePaie>> GetFichePaieListByEmployeeId(long id);
    }
}
