namespace Geometria
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

        public void CalcularPerimetro()
        {
            Console.WriteLine(float.Pi * m_radio * 2);
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine(float.Pi*m_radio*m_radio);
        }
    }

    public class Triangulo
    {
        private int altura;
        private int bass;
        private int lado3;
        public int Base
        {
            get => bass;
            set
            {
                bass = value;
            }
        }

        public int Altura
        {
            get => altura;
            set
            {
                altura = value;
            }
        }
        public int Lado
        {
            get => lado3;
            set
            {
                lado3 = value;
            }
        }


        public void CalcularPerimetro()
        {
            Console.WriteLine(bass + altura + lado3);
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine(bass * altura / 2);
        }
    }

    public class Poligono
    {
        private int lado1;
        private int lado2;
        private int lado3;
        private int lado4;

        public int Lado1
        {
            get => lado1;
            set
            {
                lado1 = value;
            }
        }
        public int Lado2
        {
            get => lado2;
            set
            {
                lado2 = value;
            }
        }
        public int Lado3
        {
            get => lado3;
            set
            {
                lado3 = value;
            }
        }
        public int Lado4
        {
            get => lado4;
            set
            {
                lado4 = value;
            }
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine(lado1 + lado2 + lado3 + lado4);
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine("No implementado");
        }
    }

    public class Cuadrado : Rectangulo
    {
        private int lado;

        public int Lado
        {
            get => lado;
            set
            {
                lado = value;
            }
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine(lado*4);
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine(lado*lado);
        }
    }

    public class Rectangulo : Poligono
    {
        private int lado1;
        private int lado2;

        public int Lado1
        {
            get => lado1;
            set
            {
                lado1 = value;
            }
        }
        public int Lado2
        {
            get => lado2;
            set
            {
                lado2 = value;
            }
        }


        public void CalcularPerimetro()
        {
            Console.WriteLine(lado1 * 2+lado2*2);
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine(lado1 * lado2);

        }
    }
}
