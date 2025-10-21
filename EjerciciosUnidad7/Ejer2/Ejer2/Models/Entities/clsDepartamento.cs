namespace Ejer2.Models.Entities
{
    public class clsDepartamento
    {
        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }

        public clsDepartamento() { }

        public clsDepartamento(int id, string nombre)
        {
            IdDepartamento = id;
            NombreDepartamento = nombre;
        }
    }
}
