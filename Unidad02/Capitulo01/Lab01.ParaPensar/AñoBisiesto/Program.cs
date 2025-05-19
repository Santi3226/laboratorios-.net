using static System.Net.Mime.MediaTypeNames;

namespace AñoBisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar año: ");
            int año = Convert.ToInt32(Console.ReadLine());


            if (año % 4 == 0 && año % 100 == 0 && año % 400 == 0)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else if (año % 4 == 0 && año % 100 == 0 && año % 400 != 0)
            {
                Console.WriteLine("El año no es bisiesto");
            }
            else Console.WriteLine("El año no es bisiesto");
        }
    }
}
