namespace Decision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar un linea:");
            string? inputTexto = Console.ReadLine(); //Como es Net.8 no hace falta agregarle el System a Console 

            Console.WriteLine("1) Mayusculas");
            Console.WriteLine("2) Minusculas");
            Console.WriteLine("3) Longitud");
            Console.WriteLine("4) Salir");

            ConsoleKeyInfo opcion = Console.ReadKey();
            while (opcion.Key != ConsoleKey.D4) {
                

                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("");
                    if (inputTexto != "") Console.WriteLine(inputTexto.ToUpper());
                    else Console.WriteLine("No se ingreso nada");
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("");
                    if (inputTexto != "") Console.WriteLine(inputTexto.ToLower());
                    else Console.WriteLine("No se ingreso nada");
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("");
                    if (inputTexto != "") Console.WriteLine(inputTexto.Length);
                    else Console.WriteLine("No se ingreso nada");
                }
                else if (opcion.Key == ConsoleKey.D4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Saliendo");
                    break;
                }
                opcion = Console.ReadKey();
            }
           


        }
    }
}
