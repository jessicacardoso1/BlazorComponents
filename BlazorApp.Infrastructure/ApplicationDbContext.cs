using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Medico> Medicos { get; set; }
    }
}
