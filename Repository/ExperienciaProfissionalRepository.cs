using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class ExperienciaProfissionalRepository : GenericRepository<ExperienciaProfissional>
    {
        public ExperienciaProfissionalRepository(IUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
        }
    }
}