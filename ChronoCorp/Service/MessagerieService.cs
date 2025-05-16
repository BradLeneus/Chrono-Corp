using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Model;
using Microsoft.EntityFrameworkCore;

namespace ChronoCorp.Service
{
    public class MessagerieService : IMessagerieService
    {
        private readonly ApplicationDbContext _dbContext;

        public MessagerieService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Messagerie>> GetAllMessageAsync()
        {
            return await _dbContext.Messagerie.ToListAsync();
        }

        public async Task<List<Messagerie>> GetMessageByTypeMessageAndEmployeeAsync(string type, long id)
        {
            return await _dbContext.Messagerie.Where(messages => messages.TypeMessage == type && messages.IdDestinataire == id).ToListAsync();
        }

        public async Task<int> GetMessageCountByEmployeeAsync(long id)
        {
            return await _dbContext.Messagerie.CountAsync(messages => messages.IdDestinataire == id);
        }
    }
}
