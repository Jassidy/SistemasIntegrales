using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemasIntegrales.DAL;
using SistemasIntegrales.ViewModels;

namespace SistemasIntegrales.Controllers
{
    public class HomeController : Controller
    {
        private TiendaContext db = new TiendaContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<EnrollmentDateGroup> data = from client in db.Clientes
                                                   group client by client.EnrollmentDate into dateGroup
                                                   select new EnrollmentDateGroup()
                                                   {
                                                       EnrollmentDate = dateGroup.Key,
                                                       NumClientes = dateGroup.Count()
                                                   };
            return View(data.ToList());

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}