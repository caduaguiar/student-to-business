using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class UsuarioRepository : GenericRepository<Usuario>
    {
        public UsuarioRepository(IUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
        }
    }
}