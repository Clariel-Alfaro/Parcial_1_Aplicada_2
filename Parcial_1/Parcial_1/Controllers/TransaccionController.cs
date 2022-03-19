using System;
using System.Collections.Generic;
using Parcial_1.Models.ViewModels;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial_1.Controllers
{
    public class TransaccionController : Controller
    {
        // GET: Transaccion
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult IndexV(TransaccionViewModel tran, String monto)
        {
            ViewBag.monto = monto;

            if (!ModelState.IsValid) { 

            return View("Index", tran);

            }
            else
            {
                if (int.Parse(monto) % 5 == 0)
                {
                    return View("Resultado");
                }
                return View("Error");

            }
            
        }


    }
}