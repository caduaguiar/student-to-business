using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;

namespace S2B_MVC.Controllers
{
    public class ExperienciaProfissionalController : Controller
    {
        //
        // GET: /ExperienciaProfissional/

        public ActionResult Index(ExperienciaProfissional ExperienciaProfissional)
        {
            
            return View(ExperienciaProfissional);
        }

    }
}
