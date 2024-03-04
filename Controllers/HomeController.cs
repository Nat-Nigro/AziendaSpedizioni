using AziendaSpedizioniDiLusso.Models;
using System;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace AziendaSpedizioniDiLusso.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        // Validator CF
        public ActionResult CheckCF(string CF)
        {
            string pattern = @"^[A-Z]{6}\d{2}[A-Z]\d{2}[A-Z]\d{3}[A-Z]$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            if (regex.IsMatch(CF))
            {

                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }


        // Validator Partita IVA
        public ActionResult CheckPartitaIVA(string PartitaIVA)
        {
            string pattern = @"^\d{11}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(PartitaIVA))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        DateTime miaData = DateTime.Today;
        public ActionResult checkDataSpedizione(DateTime data)
        {
            DateTime oggi = DateTime.Today;
            miaData = data;
            if (data >= oggi)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult checkDataConsegna(DateTime data)
        {
            if (data > miaData)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult InserisciSpedizione()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InserisciSpedizione(Spedizioni s)
        {
            return View();
        }

    }
}