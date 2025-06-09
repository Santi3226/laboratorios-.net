using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class ListaVehiculos
    {
        public static Vehiculo BuscarPatenteLINQ(List<Vehiculo> v, string patente)
        {
            Vehiculo[] veh = (from vehiculo in v where vehiculo.patente == patente select vehiculo).ToArray();
            return veh[0];
        }

        public static Vehiculo BuscarPatenteIterativa(List<Vehiculo> v, string patente)
        {
            Vehiculo vehiculoEncontrado = null;
            foreach (var vehiculo in v)
            {
                if (vehiculo.patente == patente)
                {
                    return vehiculo;
                }
            }
            return null;
        }
    }
}