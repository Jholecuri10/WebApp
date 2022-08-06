using Microsoft.EntityFrameworkCore;
using ClinicalTeams.Models;

namespace ClinicalTeams.Data
{
    public class ClinicalTeamsDbContext : DbContext
    {
        public ClinicalTeamsDbContext(DbContextOptions<ClinicalTeamsDbContext>options) : base(options) 
        {

        }
        
        public DbSet<Usuario> Registrarme { get; set; }
        public DbSet<Marca> marcas { get; set; }

    }
}
