
namespace ConsolasExito.App.Dominio
{
    public class Empleado
    {
        //Atributos
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Edad { get; set; }
        public string Identidad { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public Sucursal sucursal { get; set; }
        public NombreRol RolPerson { get; set; }
        public bool accesoReportes { get; set; }



        //Constructores
        
      
    }


}