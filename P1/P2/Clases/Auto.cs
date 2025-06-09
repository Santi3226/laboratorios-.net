using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Auto : Vehiculo
    {
        private string color;

        public Auto(string patente, int ruedas, int modelo, string color) : base(patente, ruedas, modelo)
        {
            this.color = color;
        }

        public string Color
        {
            get => color;
            set
            {
                color = value;
            }
        }

        public override string ToString()
        {
            return $"Patente: {patente}, Ruedas: {ruedas}, Modelo: {modelo}, Color: {color}";
        }
    }
}