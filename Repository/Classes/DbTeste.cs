using System.Data.Entity;

namespace Repositorio
{
    public class DbTeste:DbContext
    {
        public DbSet<Teste> Teste { get; set; }
    }
}