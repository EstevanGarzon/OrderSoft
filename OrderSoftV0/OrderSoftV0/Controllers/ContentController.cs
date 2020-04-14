using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderSoftV0.Models;

namespace OrderSoftV0.Controllers
{
    public class ContentController : Controller
    {
        public ActionResult Menu()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(Registro r)
        {
            return View();
        }
    }

}