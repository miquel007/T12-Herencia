using System;
using System.Collections.Generic;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Espectador> array = new List<Espectador>();

            Pelicula try1 = new Pelicula("Pelicano", 120, 12, "Spilver");
            Pelicula try2 = new Pelicula("Prince", 120, 3, "Disney");

            Cine cine1 = new Cine(try1, 12);
            Cine cine2 = new Cine(try2, 8);

            for (int i = 0; i < 200; i++)
            {
                Random rnd = new Random();
                array.Add(new Espectador("Pep", rnd.Next(3, 31), rnd.Next(5, 15)));
            }

            omplir(array, cine1);

            comprovar(cine1);

            omplir(array, cine2);

            comprovar(cine2);

        }

        public static void omplir(List<Espectador> array, Cine cine1)
        {
            bool colocat;
            char letra1;
            char letra2;
            int count = 1;


            foreach (Espectador n in array)
            {
                colocat = false;
                Random rnd = new Random();

                letra1 = (char)('1' + rnd.Next(0, 9));
                letra2 = (char)('A' + rnd.Next(0, 10));
                string lloc = letra1.ToString() + letra2.ToString();
                colocat = cine1.ocuparSala(lloc, n);

                if (!colocat)
                {
                    Console.WriteLine("Algo no ha anat be");
                    Console.WriteLine(n.ToString());
                }

                if (colocat)
                {
                    Console.WriteLine("S'ha colocat be, hi han {0} espectadors\n", count);
                    count++;
                }

                if (count > 72)
                    break;

            }
        }

        public static void comprovar(Cine cine1)
        {
            Dictionary<string, string> butaques = new Dictionary<string, string>();

            char letra1;
            char letra2;

            for (int Y = 0; Y < 9; Y++)
            {
                letra1 = (char)('A' + (char)Y);

                for (int K = 0; K < 8; K++)
                {
                    letra2 = (char)('1' + (char)K);

                    string prova = letra2.ToString() + letra1.ToString();

                    butaques.Add(prova, "O");
                }
            }

            Dictionary<Asiento, Espectador> nou = cine1.mostrar();

            foreach (KeyValuePair<Asiento, Espectador> knp in nou)
            {
                butaques[knp.Key.Posicion] = "X";
            }

            int count = 0;

            foreach (KeyValuePair<string, string> n in butaques)
            {
                Console.Write(n.Value);
                count++;
                if (count > 8)
                {
                    count = 0;
                    Console.Write("\n");
                }
            }

        }

    }
}
