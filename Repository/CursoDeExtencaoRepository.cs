using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class CursoDeExtencaoRepository : GenericRepository<CursoDeExtencao>
    {
        public CursoDeExtencaoRepository(IUnidadeDeTrabalho unidadeDeTrabalho) : base(unidadeDeTrabalho)
        {
        }
    }
}