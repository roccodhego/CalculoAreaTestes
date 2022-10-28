using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Circulo
    {
        public class Circulo : FormaGeometrica
    {
        private double _raio;

        public Circulo(double raio)
        {
            if (raio < 0)
            {
                throw new Exception("Não existe circulo com ráio de valor negativo");
            }
            _raio = raio;
        }

        public override double CalculadoraArea()
        {
            return _raio * _raio * Math.PI;
        }

        public void CalculadoraAreaNaoTestavel()
        {
            Console.WriteLine(_raio * _raio * Math.PI);
        }
    }
    }
}