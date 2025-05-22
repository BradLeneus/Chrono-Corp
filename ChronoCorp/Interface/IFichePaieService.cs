using ChronoCorp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChronoCorp.Interface
{
    public interface IFichePaieService
    {
        Task<List<FichePaie>> GetFichePaieListByEmployeeId(long id);
        Task InsererFichePaieAsync(FichePaie fichePaie);
    }
}
