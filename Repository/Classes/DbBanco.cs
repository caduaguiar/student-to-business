using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class DbBanco : DbContext, IUnidadeDeTrabalho
    {
        public DbBanco() : base("S2b")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
        }

        public DbSet<BeneficioDaVaga> BeneficioDaVagas { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<CandidatoVaga> CandidatoVagas { get; set; }
        

        public int Commit()
        {
            var falhaAoSalvar = false;
            var linhasAfetadas = 0;
            do
            {
                try
                {
                    linhasAfetadas = base.SaveChanges();
                }
                catch (DbUpdateConcurrencyException e)
                {
                    falhaAoSalvar = true;
                    e.Entries.ToList()
                        .ForEach(entry => entry.OriginalValues.SetValues(entry.GetDatabaseValues()));
                }
            } while (falhaAoSalvar);
            return linhasAfetadas;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}