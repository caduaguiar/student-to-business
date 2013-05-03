using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class RequisitosRepository : GenericRepository<Requisitos>
    {
        public RequisitosRepository(IUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
        }
    }
}