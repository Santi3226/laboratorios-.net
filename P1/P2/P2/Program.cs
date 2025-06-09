using Clases;
using System.Collections.Generic;

List<Vehiculo> vehiculos = new List<Vehiculo>
{
    new Auto("ABC111", 4, 1999, "Azul"),
    new Auto("XYZ789", 4, 2021, "Gris"),
    new Auto("LMN456", 2, 2019, "Negro")
};

var vehiculo1 = ListaVehiculos.BuscarPatenteLINQ(vehiculos, "ABC111");
var vehiculo2 = ListaVehiculos.BuscarPatenteIterativa(vehiculos, "ABC111");

Console.WriteLine(vehiculo1.ToString());
Console.WriteLine(vehiculo2.ToString());