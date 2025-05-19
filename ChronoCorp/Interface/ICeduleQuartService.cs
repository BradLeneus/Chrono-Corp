using ChronoCorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoCorp.Interface
{
    public interface ICeduleQuartService
    {
        Task<List<CeduleQuart>> GetAllCeduleQuartAsync();
        Task<List<CeduleQuart>> GetQuartListByEmployeeId(long id);

        //Sert à créer l'horaire
        Task AddCeduleQuartAsync(CeduleQuart quart);
        Task UpdateCeduleQuartAsync(CeduleQuart quart);
    }
}
