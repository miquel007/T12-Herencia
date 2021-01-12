using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp54
{
    public class Pelicula
    {
        private string _titulo;
        private int _tiempo;
        private int _edad;
        private string _director;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public int Tiempo
        {
            get { return _tiempo; }
            set { _tiempo = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }

        public Pelicula(string tit, int time, int min, string direc)
        {
            Titulo = tit;
            Tiempo = time;
            Edad = min;
            Director = direc;
        }

    }

}

