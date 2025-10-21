using EjerciciosUnidad7.Models.Entities;
using System.Collections.Generic;

namespace EjerciciosUnidad7.Models.DAL
{
    public class clsListadoPersonas
    {
        public static List<clsPersona> ObtenerListado()
        {
            return new List<clsPersona>
            {
                new clsPersona("Gabriel", "Villanueva", 25),
                new clsPersona("Laura", "González", 30),
                new clsPersona("Mario", "Pérez", 22),
                new clsPersona("Ana", "Martínez", 28),
                new clsPersona("Luis", "Ramírez", 35),
                new clsPersona("Sofía", "Torres", 27)
            };
        }
    }
}
