using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class CidadeRepository : GenericRepository<Cidade>
    {
        public CidadeRepository(IUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
        }
    }
}