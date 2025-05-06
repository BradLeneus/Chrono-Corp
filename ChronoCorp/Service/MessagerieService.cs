using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Model;

namespace ChronoCorp.Service
{
    public class MessagerieService : IMessagerieService
    {
        private readonly IMessagerieDataProvider _provider;

        public MessagerieService(IMessagerieDataProvider provider)
        {
            _provider = provider;
        }

        public async Task<IEnumerable<Messagerie>> GetAllMessageAsync()
        {
            return await _provider.GetAllMessageAsync();
        }

        public async Task<List<Messagerie>?> GetMessageByTypeMessageAndEmployee(string type, long id)
        {
            var messages = await _provider.GetAllMessageAsync();
            return messages.Where(messages => messages.TypeMessage == type && messages.IdDestinataire == id).ToList();
        }
    }
}
