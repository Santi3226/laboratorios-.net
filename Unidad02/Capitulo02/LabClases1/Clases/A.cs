namespace Clases
{
    public class A
    {
        string? nombre;
        public A() { nombre = "Instancia sin nombre"; }
        public string? NombreInstancia
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }

        }

        public void MostrarNombre() { Console.WriteLine(nombre); }
        public void M1() { Console.WriteLine("El metodo M1 fue invocado"); }
        public void M2() { Console.WriteLine("El metodo M2 fue invocado"); }
        public void M3() { Console.WriteLine("El metodo M3 fue invocado"); }

    }
}