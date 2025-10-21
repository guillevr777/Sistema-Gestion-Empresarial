using Ejer2.Models.DAL;
using Ejer2.Models.Entities;
using Ejer2.Models.DAL;
using Ejer2.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Ejer2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hora = DateTime.Now.Hour;
            string saludo;

            if (hora < 12)
                saludo = "Buenos días";
            else if (hora < 20)
                saludo = "Buenas tardes";
            else
                saludo = "Buenas noches";

            ViewData["Saludo"] = saludo;
            ViewBag.FechaActual = DateTime.Now.ToLongDateString();

            clsPersona persona = new clsPersona("Guillermo", "Villanueva", 21, new clsDepartamento(1, "Informática"));

            return View(persona);
        }

        public IActionResult listadoPersonas()
        {
            List<clsPersona> personas = clsListadoPersonas.ObtenerListado();
            return View(personas);
        }

        public IActionResult personaPosicion3()
        {
            List<clsPersona> personas = clsListadoPersonas.ObtenerListado();
            clsPersona personaSeleccionada = personas[3];
            return View(personaSeleccionada);
        }

        // 🔹 NUEVA ACCIÓN: Editar Persona Aleatoria
        public IActionResult EditarPersona()
        {
            List<clsPersona> personas = clsListadoPersonas.ObtenerListado();
            List<clsDepartamento> departamentos = clsListadoDepartamentos.ObtenerDepartamentos();

            // Obtener una persona aleatoria
            Random random = new Random();
            int posicion = random.Next(personas.Count);
            clsPersona personaAleatoria = personas[posicion];

            // Pasamos los departamentos por ViewBag para llenar el Select
            ViewBag.Departamentos = departamentos;

            return View(personaAleatoria);
        }
    }
}
