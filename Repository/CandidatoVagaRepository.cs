using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class CandidatoVagaRepository : GenericRepository<CandidatoVaga>
    {
        public CandidatoVagaRepository(IUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
        }
    }
}