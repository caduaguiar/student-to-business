using System.Data.Entity;
using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class BeneficioDaVagaRepository : GenericRepository<BeneficioDaVaga>
    {
        public BeneficioDaVagaRepository(IUnidadeDeTrabalho objectContext) : base(objectContext)
        {
        }
    }
}