using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeBase
{
    public class Location
    {
        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }


        public void MovePoint(int x, int y)
        {
            X += x;
            Y += y;
        }

        public System.Drawing.Point ToPoint()
        {
            return new System.Drawing.Point(X,Y);
        }
    }
}
