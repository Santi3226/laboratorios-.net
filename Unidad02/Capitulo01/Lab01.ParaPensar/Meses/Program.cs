string? mes = Console.ReadLine();
mes = mes.ToLower();

switch (mes)
{
    case "enero":
        Console.WriteLine("Enero 1");
        break;
    case "febrero":
        Console.WriteLine("Febrero 2");
        break;
    case "marzo":
        Console.WriteLine("Marzo 3");
        break;
    case "abril":
        Console.WriteLine("Abril 4");
        break;
    case "mayo":
        Console.WriteLine("Mayo 5");
        break;
    case "junio":
        Console.WriteLine("Junio 6");
        break;
    case "julio":
        Console.WriteLine("Julio 7");
        break;
    case "agosto":
        Console.WriteLine("Agosto 8");
        break;
    case "septiembre":
        Console.WriteLine("Septiembre 9");
        break;
    case "octubre":
        Console.WriteLine("Octubre 10");
        break;
    case "noviembre":
        Console.WriteLine("Noviembre 11");
        break;
    case "diciembre":
        Console.WriteLine("Diciembre 12");
        break;
    default:
        Console.WriteLine("Mes no válido");
        break;
}
