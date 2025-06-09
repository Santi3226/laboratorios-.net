using Clases;

List<Vehiculo> vehiculos = new List<Vehiculo>
{
    new Moto("ABC123", 2, 2020, "Rojo"),
    new Moto("XYZ789", 2, 2021, "Azul"),
    new Moto("123ABC", 2, 1999, "Amarillo")
};

Vehiculo v1 = Lista.BuscarPatenteLinq(vehiculos, "123ABC");
Vehiculo v2 = Lista.BuscarPatenteIteracion(vehiculos, "123ABC");  

Console.WriteLine(v1.ToString());
Console.WriteLine("");
Console.WriteLine(v2.ToString());