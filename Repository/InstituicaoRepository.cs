using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class InstituicaoRepository : GenericRepository<Instituicao>
    {
        public InstituicaoRepository(IUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
        }
    }
}