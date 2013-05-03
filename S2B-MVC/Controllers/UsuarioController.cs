using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Dominio;
using Repositorio;


namespace S2B_MVC.Controllers
{
    public class UsuarioController : ControllerBase
    {
        private IGenericRepository<Usuario> _usuario;

        public UsuarioController()
        {
            _usuario = new GenericRepository<Usuario>(UnidadeDeTrabalho);
        }

        public ActionResult Index()
        {
            return View();
        }


        // methodo de autenticação
        [HttpPost]
        public ActionResult Login(Usuario model,bool usuarioLogado)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //var aux = _usuario.GetAll().Where()
                    var select = _usuario.First(x => x.Login == model.Login && x.Senha == model.Senha);
                    usuarioLogado = true;
                    if (usuarioLogado)
                    {
                        Session["usuario"] = select.Login;
                       // rota deve ser adiciona no global.asax para que ele saiba qual é a tela de LISTA DE VAGAS
                        RedirectToRoute("ListaDeVagas");
                    }
                    else
                    {
                        RedirectToAction("Index");
                    }

                }
                catch (Exception)
                {

                    throw new Exception("Deu erro");
                }
            }
            return Json(usuarioLogado);
        }
    }
}
