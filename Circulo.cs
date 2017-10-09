using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomBS
{
    class Circulo : Figura
    {
        private int raio { get; set; }

        public Circulo(int raio)
        {
            if (raio <= 0)
            {
                Console.WriteLine("Impossivel definir valor <= 0");
                return;
            }
            this.raio = raio;
        }
        public override string ToString()
        {
            return raio.ToString();
        }

        public double getArea()
        {
            return (Math.PI * Math.Pow((double) raio, 2));
        }

        public override void Mover(int dx, int dy)
        {
            throw new NotImplementedException();
        }
    }
}