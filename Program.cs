using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomBS
{
    class Program
    {
        static void Main(string[] args)
        {
            var NovoCirculo = new Circulo(3);
            var NewSquare = new Quadrado(2);
            var NovaReta = new Reta(1, 3);
            Desenho NovoDesenho = new Desenho();
            NovoDesenho.AdicionarFiguras(NovoCirculo);
            NovoDesenho.AdicionarFiguras(NewSquare);
            NovoDesenho.AdicionarFiguras(NovaReta);
            Console.WriteLine(NovoDesenho);
           // NovoDesenho.RemoverFigura(4);
        }
    }
}
