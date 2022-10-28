using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Triangulo
    {
        public class Triangulo : FormaGeometrica
    {
        private double _base;
        private double _altura;

        public Triangulo(double base1, double altura)
        {
            if (base1 < 0)
            {
                throw new Exception("Não existe base do traiangulo com valor negativo");
            }
            else if (altura < 0)
            {
                throw new Exception("Não existe altura do traiangulo com valor negativo");
            }
            _base = base1;
            _altura = altura;
        }

        public override double CalculadoraArea()
        {
            return (_base * _altura) / 2;
        }

        public void CalculadoraAreaNaoTestavel()
        {
            Console.WriteLine((_base * _altura) / 2);
        }
    }
    }
}