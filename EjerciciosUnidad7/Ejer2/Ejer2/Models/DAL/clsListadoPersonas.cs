using Ejer2.Models.DAL;
using Ejer2.Models.Entities;
using Ejer2.Models.Entities;
using System.Collections.Generic;

namespace Ejer2.Models.DAL
{
    public class clsListadoPersonas
    {
        public static List<clsPersona> ObtenerListado()
        {
            List<clsDepartamento> departamentos = clsListadoDepartamentos.ObtenerDepartamentos();

            return new List<clsPersona>()
            {
                new clsPersona("Gabriel", "Villanueva", 25, departamentos[1]),
                new clsPersona("Laura", "González", 30, departamentos[0]),
                new clsPersona("Mario", "Pérez", 22, departamentos[2]),
                new clsPersona("Laura LuZhen", "Rodriguez", 21, departamentos[3]),
                new clsPersona("Luis", "Ramírez", 35, departamentos[4]),
                new clsPersona("Sofía", "Torres", 27, departamentos[1])
            };
        }
    }
}
