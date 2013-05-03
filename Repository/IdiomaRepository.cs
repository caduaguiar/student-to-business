using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class IdiomaRepository : GenericRepository<Idioma>
    {
        public IdiomaRepository(IUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
        }
    }
}