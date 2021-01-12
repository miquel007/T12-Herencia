using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp54
{
    public class Asiento
    {
        private string _poscicion;
        private bool _ocupado;

        public string Posicion
        {
            get { return _poscicion; }
            set { _poscicion = value; }
        }

        public bool Ocupado
        {
            get { return _ocupado; }
            set { _ocupado = value; }
        }

        public Asiento(string pos)
        {
            Posicion = pos;
            Ocupado = false;
        }
    }
}
