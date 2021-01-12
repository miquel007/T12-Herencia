using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp54
{
    public class Espectador
    {
        private string _nom;
        private int _edad;
        private int _dinero;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public int Dinero
        {
            get { return _dinero; }
            set { _dinero = value; }
        }

        public Espectador(string n, int age, int money)
        {
            Nom = n;
            Edad = age;
            Dinero = money;
        }

        public override string ToString()
        {
            return string.Format("El espectador {0} con edad {1} tiene {2} money \n", Nom, Edad, Dinero);
        }
    }

}
