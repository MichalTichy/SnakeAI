using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakeAI;

namespace UnitTests
{
    [TestClass]
    public class DistanceToFoodTests
    {

        [TestMethod, TestCategory("Heading UP")]
        public void HeadingUp_FoodDistance1()
        {
            var worldSize = new Size() {Height = 1, Width = 1};
            var world = new WorldMock(worldSize);
            world.FoodPossition=new Point(0,0);
            var snake = new SnakeMock() {Heading = Direction.Up, HeadPossition = new Point(1, 1)};
            var distance = new SnakeDistanceSence(world, snake);

            Assert.AreEqual(null, distance.DistanceToFoodAhead());
            Assert.AreEqual(null, distance.DistanceToFoodBehind());
            Assert.AreEqual(null, distance.DistanceToFoodRight());
            Assert.AreEqual(null, distance.DistanceToFoodLeft());
        }

        [TestMethod, TestCategory("Heading UP")]
        public void HeadingUp_FoodDistance2()
        {
            var worldSize = new Size() {Height = 4, Width = 4};
            var world = new WorldMock(worldSize);
            world.FoodPossition=new Point(0,1);
            var snake = new SnakeMock() {Heading = Direction.Up, HeadPossition = new Point(1, 1)};
            var distance = new SnakeDistanceSence(world, snake);

            Assert.AreEqual(null, distance.DistanceToFoodAhead());
            Assert.AreEqual(null, distance.DistanceToFoodBehind());
            Assert.AreEqual(null, distance.DistanceToFoodRight());
            Assert.AreEqual(1, distance.DistanceToFoodLeft());
        }

        [TestMethod, TestCategory("Heading UP")]
        public void HeadingUp_FoodDistance3()
        {
            var worldSize = new Size() {Height = 1, Width = 1};
            var world = new WorldMock(worldSize);
            world.FoodPossition=new Point(1,1);
            var snake = new SnakeMock() {Heading = Direction.Up, HeadPossition = new Point(1, 1)};
            var distance = new SnakeDistanceSence(world, snake);

            Assert.AreEqual(0, distance.DistanceToFoodAhead());
            Assert.AreEqual(0, distance.DistanceToFoodBehind());
            Assert.AreEqual(0, distance.DistanceToFoodRight());
            Assert.AreEqual(0, distance.DistanceToFoodLeft());
        }

        [TestMethod, TestCategory("Heading DOWN")]
        public void HeadingDown_FoodDistance1()
        {
            var worldSize = new Size() {Height = 4, Width = 4};
            var world = new WorldMock(worldSize);
            world.FoodPossition=new Point(0,1);
            var snake = new SnakeMock() {Heading = Direction.Down, HeadPossition = new Point(1, 1)};
            var distance = new SnakeDistanceSence(world, snake);

            Assert.AreEqual(null, distance.DistanceToFoodAhead());
            Assert.AreEqual(null, distance.DistanceToFoodBehind());
            Assert.AreEqual(1, distance.DistanceToFoodRight());
            Assert.AreEqual(null, distance.DistanceToFoodLeft());
        }

        [TestMethod, TestCategory("Heading RIGHT")]
        public void HeadingRight_FoodDistance1()
        {
            var worldSize = new Size() {Height = 4, Width = 4};
            var world = new WorldMock(worldSize);
            world.FoodPossition=new Point(0,1);
            var snake = new SnakeMock() {Heading = Direction.Right, HeadPossition = new Point(1, 1)};
            var distance = new SnakeDistanceSence(world, snake);

            Assert.AreEqual(null, distance.DistanceToFoodAhead());
            Assert.AreEqual(1, distance.DistanceToFoodBehind());
            Assert.AreEqual(null, distance.DistanceToFoodRight());
            Assert.AreEqual(null, distance.DistanceToFoodLeft());
        }

        [TestMethod, TestCategory("Heading LEFT")]
        public void HeadingLeft_FoodDistance1()
        {
            var worldSize = new Size() {Height = 4, Width = 4};
            var world = new WorldMock(worldSize);
            world.FoodPossition=new Point(0,1);
            var snake = new SnakeMock() {Heading = Direction.Left, HeadPossition = new Point(1, 1)};
            var distance = new SnakeDistanceSence(world, snake);

            Assert.AreEqual(1, distance.DistanceToFoodAhead());
            Assert.AreEqual(null, distance.DistanceToFoodBehind());
            Assert.AreEqual(null, distance.DistanceToFoodRight());
            Assert.AreEqual(null, distance.DistanceToFoodLeft());
        }
    }
}