using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RandomBS
{
    class Reta:Figura
    {
        private int x
        {
            get { return this.x; }
            set {}
        }

        private int y
        {
            get { return this.y; }
            set
            {
                if (value >= 0 && value > this.x) y = value;
            }
        }

        public override void Mover(int dx, int dy)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Constructor não default
        /// </summary>
        /// <param name="x">Ponto de partida da reta</param>
        /// <param name="y">Ponto de chegada da reta</param>
        public Reta(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetPerimetro()
        {
            return y - x;
        }
    }
}
