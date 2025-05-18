using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChronoCorp.Model;
using Microsoft.EntityFrameworkCore;

namespace ChronoCorp.Interface
{
    public interface IDemandeCongeService
    {
        Task<List<DemandeConge>> GetDemandeCongeListByIdEmetteur(long id);
        Task<List<DemandeConge>> GetDemandeCongeListByIdDestinataire(long id);        
        
        Task AddDemandeCongeAsync(DemandeConge demande);

        Task UpdateDemandeCongeAsync(DemandeConge demande);
    }
}
