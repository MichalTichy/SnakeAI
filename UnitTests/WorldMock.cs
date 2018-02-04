using System.Drawing;
using SnakeAI;
using SnakeAI.World;

namespace UnitTests
{
    public class WorldMock : IWorld
    {
        public WorldMock(Size size)
        {
            Size = size;
        }

        public Point FoodPossition { get; set; }
        public Size Size { get; set; }
    }
}