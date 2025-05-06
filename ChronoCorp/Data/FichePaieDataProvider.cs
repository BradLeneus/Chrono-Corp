using ChronoCorp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoCorp.Data
{
    public interface IFichePaieDataProvider
    {
        public Task<IEnumerable<FichePaie>?> GetAllFichePaieAsync();
    }
    public class FichePaieDataProvider : IFichePaieDataProvider
    {
        public async Task<IEnumerable<FichePaie>?> GetAllFichePaieAsync()
        {
            await Task.Delay(500);

            var fichesPaies = new List<FichePaie>
            {
                new FichePaie { Id = 2 }
            };

            return fichesPaies;
        }
    }
}
