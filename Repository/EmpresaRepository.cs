using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class EmpresaRepository : GenericRepository<Empresa>
    {
        public EmpresaRepository(IUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
        }
    }
}