using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Persona
    {
        private string m_nomb;

        private string m_apell;

        private int m_dni;

        public Persona()
        {
            m_nomb = "Sin nombre";
            m_apell = "Sin apellido";
            m_dni = 0;
        }
        public Persona(string n, string a, int d)
        {
            m_nomb = n;
            m_apell = a;
            m_dni = d;
        }
        public string Nombre
        {
            get => m_nomb;
            set
            {
                m_nomb = value;
            }
        }
        public string Apellido
        {
            get => m_apell;
            set
            {
                m_apell = value;
            }
        }
        public int Dni
        {
            get => m_dni;
            set
            {
                m_dni = value;
            }
        }

        public void GetName()
        {
            Console.WriteLine("Nombre: "+ Nombre+ " " + Apellido);
        }

        public void edad()
        {
            throw new System.NotImplementedException();
        }
    }
}