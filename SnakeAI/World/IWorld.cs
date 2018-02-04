using System.Drawing;

namespace SnakeAI.World
{
    public interface IWorld
    {
        Point FoodPossition { get; }
        Size Size { get; set; }
    }
}