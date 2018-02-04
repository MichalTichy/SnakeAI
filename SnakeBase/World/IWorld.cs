using System.Drawing;

namespace SnakeBase.World
{
    public interface IWorld
    {
        Point FoodPossition { get; }
        Size Size { get; set; }
    }
}