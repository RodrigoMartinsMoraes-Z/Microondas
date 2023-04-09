using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Microondas.Web.Controllers
{
    public class MicroondasController : Controller
    {
        // GET: Microondas
        public ActionResult Index()
        {
            return View();
        }
    }
}