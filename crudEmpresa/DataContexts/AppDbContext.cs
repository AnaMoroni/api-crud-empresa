using crudEmpresa.Models;
using Microsoft.EntityFrameworkCore;

namespace crudEmpresa.DataContexts
{
    public class AppDbContext : DbContext
    {

      public AppDbContext(DbContextOptions options) : base(options)
        {

        }  

        public DbSet<Empresa> Empresas { get; set; }
    }
}
