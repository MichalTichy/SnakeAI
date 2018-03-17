using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using SnakeBase.Snake;

namespace SnakeBase.World
{
    public interface IWorld
    {
        Location FoodPossition { get; }
        Size Size { get; set; }

        void AddSnakes(ICollection<ISnake> snakes);
        bool RemoveDeadSnakes();
        void PerformGameStep();
    }
}