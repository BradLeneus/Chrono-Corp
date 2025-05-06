using ChronoCorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoCorp.Data
{
    public interface ICeduleQuartDataProvider
    {
        public Task<IEnumerable<CeduleQuart>?> GetAllCeduleQuartAsync();
    }
    public class CeduleQuartDataProvider : ICeduleQuartDataProvider
    {
        public async Task<IEnumerable<CeduleQuart>?> GetAllCeduleQuartAsync()
        {
            await Task.Delay(500);

            var ceduleQuart = new List<CeduleQuart>
            {
                new CeduleQuart{ Id = 1,  IdEmployee = 432401, IdCreateur = 330201, HeureDebut = new DateTime(2025,5,5,7,0,0), HeureFin = new DateTime(2025,5,5,15,0,0)},
                new CeduleQuart{ Id = 1,  IdEmployee = 432401, IdCreateur = 330201, HeureDebut = new DateTime(2025,5,6,7,0,0), HeureFin = new DateTime(2025,5,6,15,0,0)},
                new CeduleQuart{ Id = 1,  IdEmployee = 432401, IdCreateur = 330201, HeureDebut = new DateTime(2025,5,6,7,0,0), HeureFin = new DateTime(2025,5,6,15,0,0)},
            };

            return ceduleQuart;
        }
    }
}
