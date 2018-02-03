using System;
using System.Drawing;
using SnakeAI;

namespace UnitTests
{
    public class SnakeMock: ISnake
    {
        public Direction Heading { get; set; }
        public bool IsAlive { get; }
        public Point HeadPossition { get; set; }
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