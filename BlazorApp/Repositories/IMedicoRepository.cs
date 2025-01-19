using BlazorApp.Models;

namespace BlazorApp.Repositories
{
    public interface IMedicoRepository
    {
        Task<List<Medico>> GetAllAsync();
    }
}
