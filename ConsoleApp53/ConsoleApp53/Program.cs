using System;

namespace ConsoleApp53
{
    class Program
    {
        public class Empleat
        {
            private int _sou;

            public int Sou
            {
                get { return _sou; }
                set { _sou = value; }
            }

            public Empleat(int s)
            {
                Sou = s;
            }

            public int calcularSou()
            {
                return Sou;
            }  
            

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
