using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using SnakeBase.World;

namespace SnakeBase.Snake
{
    public interface ISnake
    {
        ISnakeHead Head { get; }
        Direction Heading { get; }
        bool IsAlive { get;}
        Location HeadPossition { get; }
        ICollection<Location> BodyPossition { get; }
        void Born(IWorld world,Location initialLocation);
        void Grow();
        void Move();
        int CalcFitness();
    }
}