using System.Collections.Generic;
using System.Web.Mvc;
using Dominio;
using Repositorio;

namespace S2B_MVC.Controllers
{
    public class BeneficioDaVagaController : ControllerBase
    {
        private IGenericRepository<BeneficioDaVaga> _beneficioDaVagaRepositorio;

        public BeneficioDaVagaController()
        {
            _beneficioDaVagaRepositorio = new GenericRepository<BeneficioDaVaga>(UnidadeDeTrabalho);
        }

        public ActionResult Index()
        {
            return View();
        }

        public void Salvar(BeneficioDaVaga beneficioDaVaga)
        {
            if (!ModelState.IsValid) return;

            _beneficioDaVagaRepositorio.Add(beneficioDaVaga);
            UnidadeDeTrabalho.Commit();
        }

        public IEnumerable<BeneficioDaVaga> Listar()
        {
            return _beneficioDaVagaRepositorio.GetAll();
        }

        public void Alterar(BeneficioDaVaga beneficioDaVaga)
        {
            var beneficioAlterar = _beneficioDaVagaRepositorio.First(x => x.Id == beneficioDaVaga.Id);

            beneficioAlterar.Descricao = beneficioDaVaga.Descricao;
            beneficioAlterar.Vaga = beneficioDaVaga.Vaga;

            UnidadeDeTrabalho.Commit();
            //Context.SaveChanges();
        }
    }
}