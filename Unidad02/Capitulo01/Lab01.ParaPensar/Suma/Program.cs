namespace Suma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int suma = n1 + n2;
            Console.WriteLine("El resultado de la suma de "+n1+" y "+n2+" es "+suma);
        }
    }
}
