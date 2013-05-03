using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;

namespace S2B_MVC.Controllers
{
    public class CurriculoController : Controller
    {
       public ActionResult Index()
        {
            return View();
        }

        public ActionResult Instituicao(Instituicao instituicao)
        {
            return View(instituicao);
        }

        public ActionResult CursoDeExtencao(CursoDeExtencao cursoDeExtencao)
        {
            return View(cursoDeExtencao);
        }
    }
}
