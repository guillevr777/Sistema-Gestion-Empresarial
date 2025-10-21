using Microsoft.AspNetCore.Mvc;
using EjercicioSaludoMVC.Models.Entities;
using System;

namespace EjercicioSaludoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // ---- 1. Generar saludo según la hora ----
            int hora = DateTime.Now.Hour;
            string saludo;

            if (hora < 12)
                saludo = "Buenos días";
            else if (hora < 20)
                saludo = "Buenas tardes";
            else
                saludo = "Buenas noches";

            ViewData["Saludo"] = saludo;

            // ---- 2. Fecha actual en formato largo ----
            ViewBag.FechaActual = DateTime.Now.ToLongDateString();

            // ---- 3. Crear un objeto de clsPersona ----
            clsPersona persona = new clsPersona("Guillermo", "Villanueva", 21);

            // ---- 4. Enviar todo a la vista ----
            return View(persona);
        }
    }
}
