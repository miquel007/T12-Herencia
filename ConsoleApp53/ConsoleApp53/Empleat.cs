using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp53
{
    public class Empleat
    {
        private double _sou;

        public double Sou
        {
            get { return _sou; }
            set { _sou = value; }
        }

        public Empleat(int s)
        {
            Sou = s;
        }

        public void bonus()
        {
            double op = Sou * 1.1;
            Sou = op;
        }

        public virtual double calcularSou()
        {
            return Sou;
        }

        public virtual double calcularNet()
        {
            return Sou;
        }
    }

    public class Boss : Empleat
    {
        public Boss(int s)
            : base (s) 
        {
           
        }

        public override double calcularSou()
        {
            double op;
            op = base.calcularSou() * 1.5;
            return op;
        }

        public override double calcularNet()
        {
            double op;
            op = base.calcularNet() * 1.5 * 0.68;
            return op;
        }
    }

    public class Manager : Empleat
    {
        public Manager(int s)
            : base(s)
        {

        }

        public override double calcularSou()
        {
            double op;
            op = base.calcularSou() * 1.1;
            return op;
        }

        public override double calcularNet()
        {
            double op;
            op = base.calcularNet() * 1.1 * 0.74;
            return op;
        }
    }

    public class Empoyee : Empleat
    {
        public Empoyee(int s)
            : base(s)
        {

        }

        public override double calcularSou()
        {
            double op;
            op = base.calcularSou() * 0.85;
            return op;
        }       
    }

    public class Volunteer : Empleat
    {
        private bool ajuda;
        private double cobrar;
        public Volunteer(int s)
            : base(s)
        {
            ajuda = false;
            cobrar = 0;
        }

        public void rep_ajuda(int num)
        {
            ajuda = true;
            cobrar = num;
        }

        public override double calcularSou()
        {
            double op;
            op = base.calcularSou() * 0;
            if (ajuda)
            {
                if (cobrar > 300)
                    throw new InvalidSalaryException("L'ajuda ha superat els 300");
                else
                    op = cobrar;
            }
            return op;
        }
    }

    class InvalidSalaryException : Exception
    {
        public InvalidSalaryException(string e)
        {
            Console.WriteLine(e);
        }
    }
}
