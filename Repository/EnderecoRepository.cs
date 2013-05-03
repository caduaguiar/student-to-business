using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class EnderecoRepository : GenericRepository<Endereco>
    {
        public EnderecoRepository(IUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
        }
    }
}