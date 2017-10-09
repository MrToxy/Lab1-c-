using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomBS
{
    class Quadrado : Figura
    {
        private int Lado { get; set; }

        public Quadrado(int lado)
        {
            if (lado <= 0)
            {
                Console.WriteLine("Impossivel definir valor <= 0");
                return;
            }
            Lado = lado;
        }
        public override string ToString()
        {
            return Lado.ToString();
        }

        public double CalculateArea()
        {
            return (Math.Pow(Lado, 2));
        }

        public override void Mover(int dx, int dy)
        {
            throw new NotImplementedException();
        }
    }
}