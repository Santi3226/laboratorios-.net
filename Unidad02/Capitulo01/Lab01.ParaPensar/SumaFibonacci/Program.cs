using System.Xml.Linq;

namespace SumaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int cant = 10;
            int sum = 0;
            for (int i = 0; i < cant; i++) {
                sum = (n1) + (n2);
                if (n1 < n2) n1 = sum;
                else n2 = sum;      
            }
            Console.WriteLine("La suma de Fibonacci de "+cant+" numeros es: "+sum);
        }
    }
}
