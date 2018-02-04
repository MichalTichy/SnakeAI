using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using SnakeBase.Snake;

namespace SnakeUserControlled
{
    public class UserControlledSnakeHead : ISnakeHead
    {
        public Point Possition { get; }
        public IBrain Brain { get; }
    }
}
