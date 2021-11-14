using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POO2_CASO1_ROBLES_COLONIA_JOSE_MANUEL.Controllers
{
    public class LoginController : Controller
    {
        static string localUsername = "CIBER";
        static string localPassword = "T4CM2021";

        public ActionResult Login(string message = "")
        {
            ViewBag.MESSAGE = message;
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {

            String username = collection.Get("Username");
            String password = collection.Get("Password");

            if (!(username == localUsername && password == localPassword))
            {
                return Login("Error Usuario y/o Clave son Incorrectas");
            }

            return RedirectToAction("PapeletasPorAnio", "PREGUNTA2");
        }
    }
}