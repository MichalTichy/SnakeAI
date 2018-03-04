using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakeAI;
using SnakeBase;

namespace UnitTests
{
    [TestClass]
    public class DistanceToWallTests
    {
        [TestMethod,TestCategory("Heading UP")]
        public void HeadingUp_WallDistance1()
        {
            var worldSize = new Size(){Height = 4,Width = 4};
            var world=new WorldMock(worldSize);
            var snake=new SnakeMock(){Heading = Direction.Up,HeadPossition = new Location(1,1)};
            var distance = new SnakeDistanceSence(world,snake);
            
            Assert.AreEqual(2,distance.DistanceToWallAhead());
            Assert.AreEqual(2,distance.DistanceToWallRight());
            Assert.AreEqual(1,distance.DistanceToWallLeft());
            Assert.AreEqual(1,distance.DistanceToWallBehind());
        }

        [TestMethod,TestCategory("Heading UP")]
        public void HeadingUp_WallDistance2()
        {
            var worldSize = new Size(){Height = 4,Width = 4};
            var world=new WorldMock(worldSize);
            var snake = new SnakeMock() { Heading = Direction.Up, HeadPossition = new Location(0, 0) };
            var distance = new SnakeDistanceSence(world,snake);
            
            Assert.AreEqual(3,distance.DistanceToWallAhead());
            Assert.AreEqual(3,distance.DistanceToWallRight());
            Assert.AreEqual(0,distance.DistanceToWallLeft());
            Assert.AreEqual(0,distance.DistanceToWallBehind());
        }

        [TestMethod,TestCategory("Heading UP")]
        public void HeadingUp_WallDistance3()
        {
            var worldSize = new Size(){Height = 1,Width = 1};
            var world=new WorldMock(worldSize);
            var snake = new SnakeMock() { Heading = Direction.Up, HeadPossition = new Location(0, 0) };
            var distance = new SnakeDistanceSence(world,snake);
            
            Assert.AreEqual(0,distance.DistanceToWallAhead());
            Assert.AreEqual(0,distance.DistanceToWallRight());
            Assert.AreEqual(0,distance.DistanceToWallLeft());
            Assert.AreEqual(0,distance.DistanceToWallBehind());
        }

        [TestMethod,TestCategory("Heading DOWN")]
        public void HeadingDown_WallDistance1()
        {
            var worldSize = new Size(){Height = 4,Width = 4};
            var world=new WorldMock(worldSize);
            var snake = new SnakeMock() { Heading = Direction.Down, HeadPossition = new Location(1, 1) };
            var distance = new SnakeDistanceSence(world,snake);
            
            Assert.AreEqual(2,distance.DistanceToWallAhead());
            Assert.AreEqual(1,distance.DistanceToWallRight());
            Assert.AreEqual(2,distance.DistanceToWallLeft());
            Assert.AreEqual(1,distance.DistanceToWallBehind());
        }

        [TestMethod,TestCategory("Heading DOWN")]
        public void HeadingDown_WallDistance2()
        {
            var worldSize = new Size(){Height = 4,Width = 4};
            var world=new WorldMock(worldSize);
            var snake = new SnakeMock() { Heading = Direction.Down, HeadPossition = new Location(0, 0) };
            var distance = new SnakeDistanceSence(world,snake);
            
            Assert.AreEqual(3,distance.DistanceToWallAhead());
            Assert.AreEqual(0,distance.DistanceToWallRight());
            Assert.AreEqual(3,distance.DistanceToWallLeft());
            Assert.AreEqual(3,distance.DistanceToWallBehind());
        }

        [TestMethod,TestCategory("Heading DOWN")]
        public void HeadingDown_WallDistance3()
        {
            var worldSize = new Size(){Height = 1,Width = 1};
            var world=new WorldMock(worldSize);
            var snake = new SnakeMock() { Heading = Direction.Down, HeadPossition = new Location(0, 0) };
            var distance = new SnakeDistanceSence(world,snake);
            
            Assert.AreEqual(0,distance.DistanceToWallAhead());
            Assert.AreEqual(0,distance.DistanceToWallRight());
            Assert.AreEqual(0,distance.DistanceToWallLeft());
            Assert.AreEqual(0,distance.DistanceToWallBehind());
        }

        [TestMethod,TestCategory("Heading LEFT")]
        public void HeadingLeft_WallDistance1()
        {
            var worldSize = new Size(){Height = 4,Width = 4};
            var world=new WorldMock(worldSize);
            var snake = new SnakeMock() { Heading = Direction.Left, HeadPossition = new Location(1, 1) };
            var distance = new SnakeDistanceSence(world,snake);
            
            Assert.AreEqual(1,distance.DistanceToWallAhead());
            Assert.AreEqual(2,distance.DistanceToWallRight());
            Assert.AreEqual(1,distance.DistanceToWallLeft());
            Assert.AreEqual(2,distance.DistanceToWallBehind());
        }

        [TestMethod,TestCategory("Heading LEFT")]
        public void HeadingLeft_WallDistance2()
        {
            var worldSize = new Size(){Height = 4,Width = 4};
            var world=new WorldMock(worldSize);
            var snake = new SnakeMock() { Heading = Direction.Left, HeadPossition = new Location(0, 0) };
            var distance = new SnakeDistanceSence(world,snake);
            
            Assert.AreEqual(0,distance.DistanceToWallAhead());
            Assert.AreEqual(3,distance.DistanceToWallRight());
            Assert.AreEqual(0,distance.DistanceToWallLeft());
            Assert.AreEqual(3,distance.DistanceToWallBehind());
        }

        [TestMethod,TestCategory("Heading LEFT")]
        public void HeadingLeft_WallDistance3()
        {
            var worldSize = new Size(){Height = 1,Width = 1};
            var world=new WorldMock(worldSize);
            var snake = new SnakeMock() { Heading = Direction.Left, HeadPossition = new Location(0, 0) };
            var distance = new SnakeDistanceSence(world,snake);
            
            Assert.AreEqual(0,distance.DistanceToWallAhead());
            Assert.AreEqual(0,distance.DistanceToWallRight());
            Assert.AreEqual(0,distance.DistanceToWallLeft());
            Assert.AreEqual(0,distance.DistanceToWallBehind());
        }

        [TestMethod, TestCategory("Heading RIGHT")]
        public void HeadingRight_WallDistance1()
        {
            var worldSize = new Size() { Height = 4, Width = 4 };
            var world = new WorldMock(worldSize);
            var snake = new SnakeMock() { Heading = Direction.Right, HeadPossition = new Location(1, 1) };
            var distance = new SnakeDistanceSence(world, snake);

            Assert.AreEqual(2, distance.DistanceToWallAhead());
            Assert.AreEqual(1, distance.DistanceToWallRight());
            Assert.AreEqual(2, distance.DistanceToWallLeft());
            Assert.AreEqual(1, distance.DistanceToWallBehind());
        }

        [TestMethod, TestCategory("Heading RIGHT")]
        public void HeadingRight_WallDistance2()
        {
            var worldSize = new Size() { Height = 4, Width = 4 };
            var world = new WorldMock(worldSize);
            var snake = new SnakeMock() { Heading = Direction.Right, HeadPossition = new Location(0, 0) };
            var distance = new SnakeDistanceSence(world, snake);

            Assert.AreEqual(3, distance.DistanceToWallAhead());
            Assert.AreEqual(0, distance.DistanceToWallRight());
            Assert.AreEqual(3, distance.DistanceToWallLeft());
            Assert.AreEqual(0, distance.DistanceToWallBehind());
        }

        [TestMethod, TestCategory("Heading RIGHT")]
        public void HeadingRight_WallDistance3()
        {
            var worldSize = new Size() { Height = 1, Width = 1 };
            var world = new WorldMock(worldSize);
            var snake = new SnakeMock() { Heading = Direction.Right, HeadPossition = new Location(0, 0) };
            var distance = new SnakeDistanceSence(world, snake);

            Assert.AreEqual(0, distance.DistanceToWallAhead());
            Assert.AreEqual(0, distance.DistanceToWallRight());
            Assert.AreEqual(0, distance.DistanceToWallLeft());
            Assert.AreEqual(0, distance.DistanceToWallBehind());
        }
    }
}
