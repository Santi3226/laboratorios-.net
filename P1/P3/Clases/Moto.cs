using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Moto : Vehiculo
    {
        private string color;
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
            return base.ToString() + $" - Color {Color}";
        }

        public Moto(string patente, int ruedas, int modelo, string color) : base(patente, ruedas, modelo)
        {
            this.Patente = patente;
            this.Ruedas = ruedas;
            this.Modelo = modelo;
            this.Color = color;
        }
    }
}