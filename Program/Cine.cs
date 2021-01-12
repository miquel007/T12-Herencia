using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp54
{
    public class Cine
    {
        private Pelicula _peli;
        private int _precio;
        private List<Asiento> _asientos;
        private Dictionary<Asiento, Espectador> ocupacio = new Dictionary<Asiento, Espectador>();

        public Pelicula Pelis
        {
            get { return _peli; }
            set { _peli = value; }
        }

        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public List<Asiento> Asientos
        {
            get { return _asientos; }
            set { _asientos = value; }
        }

        public Cine(Pelicula pel, int pre)
        {
            Pelis = pel;
            Precio = pre;
            Asientos = generarAsientos();
        }

        private List<Asiento> generarAsientos()
        {
            char letra1;
            char letra2;
            List<Asiento> array = new List<Asiento>();

            for (int Y = 0; Y < 9; Y++)
            {
                letra1 = (char)('A' + (char)Y);

                for (int K = 0; K < 8; K++)
                {
                    letra2 = (char)('1' + (char)K);

                    string prova = letra2.ToString() + letra1.ToString();

                    Asiento nou = new Asiento(prova);

                    array.Add(nou);
                }
            }

            return array;
        }

        public bool ocuparSala(string lloc, Espectador client)
        {
            bool fi = false;

            if (Pelis.Edad > client.Edad)
                return fi;
            else if (client.Dinero > Precio)
            {
                foreach (Asiento n in Asientos)
                {
                    if (n.Posicion.Equals(lloc) && !n.Ocupado)
                    {
                        n.Ocupado = true;
                        client.Dinero = client.Dinero - Precio;
                        ocupacio.Add(n, client);
                        fi = true;
                        break;
                    }
                }

                if (!fi)
                    fi = forzarOcupacio(client);
            }
            else
                return fi;
            return fi;
        }

        private bool forzarOcupacio(Espectador client)
        {
            bool fi = false;

            foreach (Asiento n in Asientos)
                if (!n.Ocupado)
                {
                    n.Ocupado = true;
                    client.Dinero = client.Dinero - Precio;
                    ocupacio.Add(n, client);
                    fi = true;
                    break;
                }

            return fi;
        }

        public Dictionary<Asiento, Espectador> mostrar()
        {
            return ocupacio;
        }

    }

}
