using System.IO;

namespace Clases
{
    public class Persona
    {
        private string? nombre;
        private string? apellido;
        private int edad;
        private int dni;

        public Persona()
        { 
            nombre = Console.ReadLine();
            apellido = Console.ReadLine();
            edad = Convert.ToInt32(Console.ReadLine());
            dni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Se creo la instancia: "+nombre);
        }
        ~Persona()
        {
            Console.WriteLine("Se destruyo la instancia: " + nombre);
        }

        public string Apellido
        {
            get => apellido;
            set
            {
                apellido = value;
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
            }
        }

        public int Edad
        {
            get => edad;
            set
            {
                edad = value;
            }
        }

        public int Dni
        {
            get => dni;
            set
            {
                dni = value;
            }
        }
        public void GetFullName()
        {
            Console.WriteLine("Nombre completo: " + nombre + " " + apellido);
        }
        public void GetAge()
        {
            Console.WriteLine("Edad: " + edad);
        }
    }
}

