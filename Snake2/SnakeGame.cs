using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Snake2
{

    public enum Direccio
    {
        Dreta,Esquerra,Avall,Amunt
    }
    class SnakeGame
    {
        public const int X_SIZE = 5;
        public const int Y_SIZE = 5;



        Point capSerp = new Point(0,0);
        Direccio direccio = Direccio.Avall;

        public Point CapSerp { get => capSerp; set => capSerp = value; }
        public Direccio Direccio { get => direccio; set => direccio = value; }

        internal void moure()
        {
            capSerp.Y++;

        }
    }
}
