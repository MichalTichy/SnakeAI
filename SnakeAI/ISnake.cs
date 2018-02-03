using System.Drawing;

namespace SnakeAI
{
    public interface ISnake
    {
        Direction Heading { get; }
        bool IsAlive { get;}
        Point HeadPossition { get; }
        void Grow();
        void Move();
    }
}