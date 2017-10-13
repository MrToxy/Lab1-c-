using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomBS
{
    public class Desenho : IMovimentavel
    {
        private List<Figura> Figuras = new List<Figura>();

		public Desenho()
		{
			Figuras.add(Figura NovaFigura = new Figura();
		}
        public void AdicionarFiguras(Figura NovaFigura)
        {
            Figuras.Add(NovaFigura);
        }

        public override string ToString()
        {
            var toReturn = "";
            Console.WriteLine("Lista de figuras:");
            foreach (var Figura in Figuras)
            {
                var tipo = Figura.GetType().ToString();
                tipo = tipo.Substring(tipo.IndexOf('.') + 1);
                if (tipo == "Circulo")
                    toReturn += "Circulo\nRaio:" + Figura;
                else toReturn += "\nQuadrado\nLado:" + Figura;
            }
            return toReturn;
        }

        public void Mover(int dx, int dy)
        {
           foreach(var figura in Figuras)
		   {
		     figura.Mover(dx,dy);
		   }
        }

        public void GetArea()
        {
            var @string = "";
            foreach (var figura in Figuras)
            {
               
                if (figura is Circulo)
                {
                    @string += "Aréa Circulo:" + ((Circulo) figura).getArea();
                }
                else
                {
                    @string += "\n" + ((Quadrado) figura).CalculateArea();
                }
            }
        }

        public void RemoverFigura(int indice)
        {
            if (Figuras.ElementAtOrDefault(indice) != null)
                Figuras.RemoveAt(indice);
            else
            {
                Console.WriteLine("O index especificado não existe");
            }
        }
    }
}