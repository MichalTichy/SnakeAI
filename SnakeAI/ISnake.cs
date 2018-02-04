﻿using System.Collections.Generic;
using System.Drawing;

namespace SnakeAI
{
    public interface ISnake
    {
        Direction Heading { get; }
        bool IsAlive { get;}
        Point HeadPossition { get; }
        ICollection<Point> BodyPossition { get; }
        void Grow();
        void Move();
    }
}