using System.Collections.Generic;
using System.Drawing;

namespace SnakeBase.Snake
{
    public interface ISnake
    {
        ISnakeHead Head { get; }
        Direction Heading { get; }
        bool IsAlive { get;}
        Location HeadPossition { get; }
        ICollection<Location> BodyPossition { get; }
        void Grow();
        void Move();
    }
}