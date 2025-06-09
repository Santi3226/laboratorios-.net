using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Lista
    {
        public static Vehiculo BuscarPatenteLinq(List<Vehiculo> vehiculos, string patente)
        {
            var vehiculo = (from v in vehiculos where v.Patente == patente select v);
            return vehiculo.FirstOrDefault();
        }
        public static Vehiculo BuscarPatenteIteracion(List<Vehiculo> vehiculos, string patente)
        {
            foreach (Vehiculo v in vehiculos)
            {
                if (v.Patente == patente)
                {
                    return v;
                }
            }
            Console.WriteLine("No se encontro");
            return null;
        }
    }
}