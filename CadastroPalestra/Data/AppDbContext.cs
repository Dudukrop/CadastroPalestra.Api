using CadastroPalestra.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroPalestra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Participante> Participante { get; set; }
    }
}
