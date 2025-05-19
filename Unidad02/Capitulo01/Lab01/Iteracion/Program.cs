namespace Iteracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string?[] array = new string[cantIteraciones];
            Console.WriteLine("Rellenar un arreglo de 5 strings:");
            for (int i = 0; i < cantIteraciones; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("El arreglo ingresado, de adelante a atras:");

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
