using System.Collections.Generic;
using System.Drawing;
using SnakeBase;
using SnakeBase.Snake;
using SnakeBase.World;

namespace UnitTests
{
    public class WorldMock : IWorld
    {
        public WorldMock(Size size)
        {
            Size = size;
        }

        public Location FoodPossition { get; set; }
        public Size Size { get; set; }
        public void AddSnakes(ICollection<ISnake> snakes)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveDeadSnakes()
        {
            throw new System.NotImplementedException();
        }

        public void PerformGameStep()
        {
            throw new System.NotImplementedException();
        }
    }
}