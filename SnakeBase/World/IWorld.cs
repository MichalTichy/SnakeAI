using System.Collections.Generic;
using System.Drawing;
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