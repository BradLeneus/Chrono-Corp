using ChronoCorp.Model;

namespace ChronoCorp.Interface
{
    public interface IMessagerieService
    {
        Task<List<Messagerie>?> GetMessageByTypeMessageAndEmployeeAsync(string type, long id);
        Task<int> GetMessageCountByEmployeeAsync(long id);
    }
}
