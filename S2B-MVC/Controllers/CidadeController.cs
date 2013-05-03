using System.Collections.Generic;
using System.Web.Mvc;
using Dominio;
using Repositorio;


namespace S2B_MVC.Controllers
{
    public class CidadeController :ControllerBase
    {
       
        private IGenericRepository<Cidade> _cidade;

        public ActionResult Index()
        {
            return View(_cidade.GetAll());
        }
        public void Salvar(Cidade cidade)
        {
            if (!ModelState.IsValid) return;

            _cidade.Add(cidade);
            UnidadeDeTrabalho.Commit();
        }

        public IEnumerable<Cidade> Listar()
        {
            return _cidade.GetAll();
        }

        public void Alterar(Cidade  cidade)
        {
            var cidadeAlterar = _cidade.First(x => x.Id == cidade.Id);

            cidadeAlterar.Nome = cidade.Nome;
            cidadeAlterar.Estado = cidade.Estado;

           // salva no banco as alteraçoes feitas
            UnidadeDeTrabalho.Commit();

        }
      
    }
}
