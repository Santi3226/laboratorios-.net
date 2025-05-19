namespace AdivinaNumero
{
    public class Juego
    {
        private int record;

        public Juego()
        {
        }
        
        public void ComenzarJuego()
        {
            bool continuarJ = true;
            while (continuarJ) 
            {
            Console.WriteLine("\nBienvenido al juego de adivinar el número\n");
            JugadaAyuda jugada = new JugadaAyuda(PreguntarMaximo());
            bool continuar = true;
                while(continuar)
                {
                    jugada.Comparar(PreguntarNumero());
                    continuar = !(jugada.Adivino);
                }

                if (jugada.Adivino) 
                { 
                    Comparar(jugada.Intentos);
                    continuarJ = Continuar();
                }

            }
        }
        private void Comparar(int nrec)
        {
            if (record==0)
            {
                Console.WriteLine("Nuevo record en " + nrec + " intentos!");
                record = nrec;
            }
            else if( record > nrec ) 
            {
                Console.WriteLine("Nuevo record en " + nrec + " intentos!");
                record = nrec;
            }
            else if (record <= nrec)
            {
                Console.WriteLine("Completado en: " + nrec + " intentos! (Record: "+record+")");
            }
        }
        public bool Continuar()
        {
            Console.WriteLine("\nDesea volver a jugar? (0 para salir)");
            int rta = Convert.ToInt32(Console.ReadLine());
            if (rta==0) { return false; } else { return true; }
        }
        private int PreguntarMaximo()
        {
            Console.WriteLine("¿Cuál es el número máximo?");
            int maximo = Convert.ToInt32(Console.ReadLine());
            return maximo;
        }
        private int PreguntarNumero()
        {
            Console.WriteLine("\n¿Cuál es el número?");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
    }

    public class Programa
    {
        public void Main()
        {
            Juego juego = new Juego();
            juego.ComenzarJuego();
        }
    }

    public class Jugada
    {
        private bool adivino;
        private int intentos;
        private int numero;
        public bool Adivino
        {
            get => adivino;
            set
            {
                adivino = value;
            }
        }

        public int Intentos
        {
            get => intentos;
            set
            {
                intentos = value;
            }
        }

        public int Numero
        {
            get => numero;
            set
            {
                numero = value;
            }
        }

        public void Comparar(int num)
        {
            Intentos = Intentos + 1;
            if (Numero == num) 
            {
                Console.WriteLine("\n¡Adivinaste el número!");
                Adivino = true;
            }
            else
            { 
                Console.WriteLine("\nNo adivinaste el número...");
                Adivino = false;
            }

        }
    }

    public class JugadaAyuda : Jugada
    {
        private bool adivino;
        private int intentos;
        private int numero;

        public JugadaAyuda(int max)
        {
            Intentos = 0;
            Adivino = false;
            Random rnd = new Random();
            Numero = rnd.Next(max);
        }

        public bool Adivino
        {
            get => adivino;
            set
            {
                adivino = value;
            }
        }

        public int Intentos
        {
            get => intentos;
            set
            {
                intentos = value;
            }
        }

        public int Numero
        {
            get => numero;
            set
            {
                numero = value;
            }
        }

        public void Comparar(int num)
        {
            Intentos = Intentos + 1;
            if (Numero == num)
            {
                Console.WriteLine("\n¡Adivinaste el número!");
                Adivino = true;
            }
            else
            {
                Console.WriteLine("\nNo adivinaste el número...");
                Adivino = false;
                if (Math.Abs(Numero - num) >= 100) { Console.WriteLine("\nPista: tu numero está al menos 100 unidades mas lejos"); }
                if (Math.Abs(Numero - num)<= 5) { Console.WriteLine("\nPista: tu numero está dentro de las 5 unidades mas cercanas!"); }
            }

        }
    }
}
