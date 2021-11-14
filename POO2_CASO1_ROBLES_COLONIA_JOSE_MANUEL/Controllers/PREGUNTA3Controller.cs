using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POO2_CASO1_ROBLES_COLONIA_JOSE_MANUEL.Controllers
{
    public class PREGUNTA3Controller : Controller
    {
        Policia_DAO policiaDao = new Policia_DAO();
        Papeletas_DAO papeletasDao = new Papeletas_DAO();

        public ActionResult PapeletasPorPoliciaAnio(string codipol = "", int anio = 0)
        {
            var listaPapeletas = papeletasDao.PapeletasPorPoliciaAnio(codipol, anio);

            ViewBag.POLICIAS = new SelectList(
                policiaDao.Policias(),
                "codpol",
                "nompol"
                );

            ViewBag.ANIO = anio;

            return View(listaPapeletas);
        }
    }
}