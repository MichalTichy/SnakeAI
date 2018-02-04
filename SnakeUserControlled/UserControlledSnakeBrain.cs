using System;
using System.Collections.Generic;
using System.Text;
using SnakeBase;
using SnakeBase.Snake;

namespace SnakeUserControlled
{
    public class UserControlledSnakeBrain : IBrain
    {
        protected Direction nextMove=Direction.Right;
        public Direction DetermineNextMove()
        {
            return nextMove;
        }

        public void GoUp()
        {
            nextMove = Direction.Up;
        }

        public void GoDown()
        {
            nextMove = Direction.Down;
        }

        public void GoLeft()
        {
            nextMove = Direction.Left;
        }

        public void GoRight()
        {
            nextMove = Direction.Right;
        }
    }
}
