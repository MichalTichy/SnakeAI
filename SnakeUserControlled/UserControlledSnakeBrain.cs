using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SnakeBase;
using SnakeBase.Snake;

namespace SnakeUserControlled
{
    public class UserControlledSnakeBrain : IBrain
    {
        protected Queue<Direction> nextMoves=new Queue<Direction>();
        protected Direction last=Direction.Right;
        public Direction DetermineNextMove()
        {
            Direction next;
            if (nextMoves.Any())
                next = nextMoves.Dequeue();
            else
                next = last;
            last = next;
            return next;
        }

        public void GoUp()
        {
            nextMoves.Enqueue(Direction.Up);
        }

        public void GoDown()
        {
            nextMoves.Enqueue(Direction.Down);
        }

        public void GoLeft()
        {
            nextMoves.Enqueue(Direction.Left);
        }

        public void GoRight()
        {
            nextMoves.Enqueue(Direction.Right);
        }
    }
}
