using Ejer2.Models.Entities;
using Ejer2.Models.Entities;
using System.Collections.Generic;

namespace Ejer2.Models.DAL
{
    public class clsListadoDepartamentos
    {
        public static List<clsDepartamento> ObtenerDepartamentos()
        {
            return new List<clsDepartamento>()
            {
                new clsDepartamento(1, "Recursos Humanos"),
                new clsDepartamento(2, "Informática"),
                new clsDepartamento(3, "Marketing"),
                new clsDepartamento(4, "Finanzas"),
                new clsDepartamento(5, "Logística")
            };
        }
    }
}
