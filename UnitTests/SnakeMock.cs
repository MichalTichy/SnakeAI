using System;
using System.Collections.Generic;
using System.Drawing;
using SnakeAI;
using SnakeAI.Snake;
using SnakeBase;
using SnakeBase.Snake;

namespace UnitTests
{
    public class SnakeMock: ISnake
    {
        public Direction Heading { get; set; }
        public bool IsAlive { get; }
        public Point HeadPossition { get; set; }
        public ICollection<Point> BodyPossition { get; set; }

        public void Grow()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}