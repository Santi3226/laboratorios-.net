using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public abstract class Vehiculo
    {
        public string patente;
        public int ruedas;
        public int modelo;

        protected Vehiculo(string patente, int ruedas, int modelo)
        {
            this.patente = patente;
            this.ruedas = ruedas;
            this.modelo = modelo;
        }

        public int Modelo
        {
            get => modelo;
            set
            {
                modelo = value;
            }
        }

        public string Patente
        {
            get => patente;
            set
            {
                patente = value;
            }
        }

        public int Ruedas
        {
            get => ruedas;
            set
            {
                ruedas = value;
            }
        }

        public override string ToString()
        {
            return $"Patente: {patente}, Ruedas: {ruedas}, Modelo: {modelo}";
        }
    }
}