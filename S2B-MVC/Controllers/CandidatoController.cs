using System.Collections.Generic;
using System.Web.Mvc;
using Dominio;
using Repositorio;


namespace S2B_MVC.Controllers
{
    public class CandidatoController : ControllerBase
    {
        private IGenericRepository<Candidato> _candidato;

        public ActionResult Index()
        {
            return View(_candidato.GetAll());
        }
        public void Salvar(Candidato candidato)
        {
            if (!ModelState.IsValid) return;

            _candidato.Add(candidato);
            UnidadeDeTrabalho.Commit();
        }

        public IEnumerable<Candidato> Listar()
        {
            return _candidato.GetAll();
        }

        public void Alterar(Candidato candidato)
        {
            var candidatoAlterar = _candidato.First(x => x.Id == candidato.Id);

            candidatoAlterar.Cpf = candidato.Cpf;
            candidatoAlterar.Email = candidato.Email;
            candidatoAlterar.Enderecos = candidato.Enderecos;
            candidatoAlterar.Facebook = candidato.Facebook;
            candidatoAlterar.Nascimento = candidato.Nascimento;
            candidatoAlterar.Nome = candidato.Nome;
            candidatoAlterar.Sexo = candidato.Sexo;
            candidatoAlterar.Site = candidato.Site;
            candidatoAlterar.Telefone = candidato.Telefone;
            candidatoAlterar.Twitter = candidato.Twitter;

            // salva no banco as alteraçoes feitas
            UnidadeDeTrabalho.Commit();
            
        }
    }
}
