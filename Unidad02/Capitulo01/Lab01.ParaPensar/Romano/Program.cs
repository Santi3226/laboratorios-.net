Console.WriteLine("Ingrese un número entre 1 y 3999 para convertir a romano (0 para salir):");
int n = Convert.ToInt32(Console.ReadLine());
string romano = "";

while (n != 0) 
{
    var valores = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    var simbolos = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

    if (n < 1 || n > 3999)
    {
        Console.WriteLine("El número debe estar entre 1 y 3999.");
    }
    else
    {
        for (int i = 0; i < valores.Length; i++)
        {
            while (n >= valores[i])
            {
                romano += simbolos[i];
                n -= valores[i];
            }
        }
        Console.WriteLine("El número romano es: " + romano);
    }
         n = Convert.ToInt32(Console.ReadLine());
         romano = "";
}