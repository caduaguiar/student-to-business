using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class VagaRepository : GenericRepository<Vaga>
    {
        public VagaRepository(IUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
        }
    }
}