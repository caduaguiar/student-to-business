using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class CurriculoRepository : GenericRepository<Curriculo>
    {
        public CurriculoRepository(IUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
        }
    }
}