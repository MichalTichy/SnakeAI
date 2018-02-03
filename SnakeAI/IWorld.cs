using System.Drawing;

namespace SnakeAI
{
    public interface IWorld
    {
        Point FoodPossition { get; }
        Size Size { get; set; }
    }
}