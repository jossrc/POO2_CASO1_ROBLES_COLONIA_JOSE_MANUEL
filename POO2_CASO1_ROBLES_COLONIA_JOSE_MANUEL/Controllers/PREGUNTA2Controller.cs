using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POO2_CASO1_ROBLES_COLONIA_JOSE_MANUEL.Controllers
{
    public class PREGUNTA2Controller : Controller
    {
        Papeletas_DAO papeletasDao = new Papeletas_DAO();

        public ActionResult PapeletasPorAnio(int anio = 0)
        {
            var list = papeletasDao.PapeletasPorAnio(anio);

            ViewBag.ANIO = anio;

            return View(list);
        }
    }
}