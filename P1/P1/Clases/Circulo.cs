using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Circulo
    {
        private int m_radio;
        public int Radio
        {
            get => m_radio;
            set
            {
                m_radio = value;
            }
        }
        public Circulo(int rad)
        {
            Radio = rad;
        }
        public Circulo()
        {
            Radio = 3;
        }
        public void GetPer()
        {
            double per = 2 * Radio * Math.PI;
            Console.WriteLine(per);
        }

        public void GetArea()
        {
            float area = (Radio * Radio) * (float)Math.PI;
            Console.WriteLine(area);
        }
    }
}