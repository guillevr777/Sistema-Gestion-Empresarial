using EjerciciosUnidad7.Models;
using EjerciciosUnidad7.Models.DAL;
using EjerciciosUnidad7.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjerciciosUnidad7.Controllers
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
            string saludo;
            int hora = DateTime.Now.Hour;

            if (hora < 12)
                saludo = "¡Buenos días!";
            else if (hora < 20)
                saludo = "¡Buenas tardes!";
            else
                saludo = "¡Buenas noches!";

            ViewData["Saludo"] = saludo;
            ViewBag.FechaActual = DateTime.Now.ToLongDateString();

            clsPersona persona = new clsPersona("Gabriel", "Villanueva", 25);

            return View(persona);
        }

        public IActionResult ListadoPersonas()
        {
            List<clsPersona> listado = clsListadoPersonas.ObtenerListado();
            return View(listado);
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
