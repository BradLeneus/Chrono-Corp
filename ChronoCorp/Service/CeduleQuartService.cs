using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoCorp.Service
{
    public class CeduleQuartService : ICeduleQuartService
    {
        private readonly ICeduleQuartDataProvider _provider;

        public CeduleQuartService(ICeduleQuartDataProvider provider)
        {
            _provider = provider;
        }

        public async Task<IEnumerable<CeduleQuart>> GetAllCeduleQuartAsync()
        {
            return await _provider.GetAllCeduleQuartAsync();
        }

        // ajouter date deb, date fin
        public async Task<List<CeduleQuart>> GetCeduleQuartListByCreatorId(long id)
        {
            var cedules = await _provider.GetAllCeduleQuartAsync();
            return cedules.Where(cedule => cedule.IdCreateur == id).ToList();
        }

        // ajouter date deb, date fin
        public async Task<List<CeduleQuart>> GetCeduleQuartListByEmployeeId(long id)
        {
            var cedules = await _provider.GetAllCeduleQuartAsync();
            return cedules.Where(cedule => cedule.IdEmployee == id).ToList();
        }
    }
}
