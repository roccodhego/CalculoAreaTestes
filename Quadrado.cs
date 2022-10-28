using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Quadrado
    {
        public class Quadrado : FormaGeometrica
    {
        private double _lado;
        public Quadrado(double lado)
        {
            if (lado < 0)
            {
                throw new Exception("Não existe circulo com ráio de valor negativo");
            }
            _lado = lado;
        }

        public override double CalculadoraArea()
        {
            return _lado * _lado;
        }

        public void CalculadoraAreaNaoTestavel()
        {
            Console.WriteLine(_lado * _lado);
        }
    }
    }
}