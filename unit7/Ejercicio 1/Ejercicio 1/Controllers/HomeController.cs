using System.Diagnostics;
using Ejercicio_1.Models;
using Ejercicio_1.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Ejercicio_1.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int hora = DateTime.Now.Hour;
            clsPersona persona = new clsPersona(1,"juan" );


            ViewData["Hora"] = hora;
            if (hora < 12)
            {
                ViewData["Mensaje"] = "Buenos días";
            }
            else if (hora < 20)
            {
                ViewData["Mensaje"] = "Buenas tardes";
            }
            else
            {
                ViewData["Mensaje"] = "Buenas noches";
            }
            DateTime fecha = DateTime.Now;
            string fechalarga = fecha.ToLongDateString();


            ViewBag.Fecha = fecha;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



       
    }
}
