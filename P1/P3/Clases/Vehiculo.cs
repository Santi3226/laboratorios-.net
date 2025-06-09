using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public abstract class Vehiculo
    {
        private string patente;
        private int ruedas;
        private int modelo;
        public string Patente { get; set; }
        public int Ruedas { get; set; }
        public int Modelo { get; set; }

        protected Vehiculo(string patente, int ruedas, int modelo)
        {
            this.Patente = patente;
            this.Ruedas = ruedas;
            this.Modelo = modelo;
        }

        public override string ToString()
        {
            return $"Patente: {Patente} - Ruedas: {Ruedas} - Modelo: {Modelo}";
        }
    }
}