using ChronoCorp.Model;

namespace ChronoCorp.Interface
{
    public interface ITypeQuartService
    {
        Task<List<TypeQuart>> GetAllTypeQuartAsync();
    }
}
