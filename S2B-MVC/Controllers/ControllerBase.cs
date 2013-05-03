using System.Web.Mvc;
using Repositorio;
using Repositorio.Interfaces;

namespace S2B_MVC.Controllers
{
    public class ControllerBase : Controller
    {
        protected IUnidadeDeTrabalho UnidadeDeTrabalho;

        public ControllerBase()
        {
            UnidadeDeTrabalho = new DbBanco();
        }

    }
}
