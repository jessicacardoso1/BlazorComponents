using BlazorComponent.Models;

namespace BlazorComponent.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        public async Task<List<Medico>> GetAllAsync()
        {
            return new List<Medico>
            { 
                new Medico{ Id = 1, Nome = "João Gabriel", Crm = "ABCD123"},
                new Medico{ Id = 2, Nome = "João Gabriel", Crm = "ABCD123"},
                new Medico{ Id = 3, Nome = "João Gabriel", Crm = "ABCD123"},
                new Medico{ Id = 4, Nome = "João Gabriel", Crm = "ABCD123"},
                new Medico{ Id = 5, Nome = "João Gabriel", Crm = "ABCD123"},
            };
        }
    }
}
