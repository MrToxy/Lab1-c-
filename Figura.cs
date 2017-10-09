using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomBS
{
    abstract class Figura : IMovimentavel
    {
        protected int x { get; set; }
        protected int y { get; set; }

       /* public void Mover(int dx, int dy)
        {
            this.x += dx;
            this.y += dy;
        }*/

        public abstract void Mover(int dx, int dy);
    }
}