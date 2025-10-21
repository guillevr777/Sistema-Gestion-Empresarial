namespace EjercicioSaludoMVC.Models.Entities
{
    public class clsPersona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public clsPersona() { }

        public clsPersona(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }
    }
}
