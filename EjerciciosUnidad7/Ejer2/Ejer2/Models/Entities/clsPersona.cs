using Ejer2.Models.Entities;

namespace Ejer2.Models.Entities
{
    public class clsPersona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public clsDepartamento Departamento { get; set; }

        public clsPersona() { }

        public clsPersona(string nombre, string apellidos, int edad, clsDepartamento departamento)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Departamento = departamento;
        }
    }
}
