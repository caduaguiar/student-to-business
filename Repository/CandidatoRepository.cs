using System.Data.Entity;
using Dominio;
using Repositorio.Interfaces;

namespace Repositorio
{
    public class CandidatoRepository:GenericRepository<Candidato>
    {
        public CandidatoRepository(IUnidadeDeTrabalho objectContext) : base(objectContext)
        {
        }
    }
}