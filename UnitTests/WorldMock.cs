using System.Drawing;
using SnakeBase.World;

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