using System;

namespace SnakeAI
{
    public class Distance
    {
        private readonly IWorld world;
        private readonly ISnake snake;

        public int? DistanceToWallAhead => CalcDistanceToWallAhead();
        public int? DistanceToWallBehind => CalcDistanceToWallBehind();
        public int? DistanceToWallRight => CalcDistanceToWallRight();
        public int? DistanceToWallLeft => CalcDistanceToWallLeft();

        public int? DistanceToFoodAhead => throw new NotImplementedException();
        public int? DistanceToFoodBehind => throw new NotImplementedException();
        public int? DistanceToFoodRight => throw new NotImplementedException();
        public int? DistanceToFoodLeft => throw new NotImplementedException();

        public Distance(IWorld world,ISnake snake)
        {
            this.world = world;
            this.snake = snake;
        }

        protected virtual int? CalcDistanceToWallAhead()
        {
            switch (snake.Heading)
            {
                case Direction.Up:
                    return world.Size.Height - snake.HeadPossition.Y- 1;
                case Direction.Down:
                    return snake.HeadPossition.Y;
                case Direction.Left:
                    return snake.HeadPossition.X;
                case Direction.Right:
                    return world.Size.Width - snake.HeadPossition.X - 1;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        protected virtual int? CalcDistanceToWallBehind()
        {
            switch (snake.Heading)
            {
                case Direction.Down:
                    return world.Size.Height - snake.HeadPossition.Y- 1;
                case Direction.Up:
                    return snake.HeadPossition.Y;
                case Direction.Right:
                    return snake.HeadPossition.X;
                case Direction.Left:
                    return world.Size.Width - snake.HeadPossition.X - 1;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        protected virtual int? CalcDistanceToWallRight()
        {
            switch (snake.Heading)
            {
                case Direction.Left:
                    return world.Size.Height - snake.HeadPossition.Y- 1;
                case Direction.Right:
                    return snake.HeadPossition.Y;
                case Direction.Down:
                    return snake.HeadPossition.X;
                case Direction.Up:
                    return world.Size.Width - snake.HeadPossition.X - 1;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        protected virtual int? CalcDistanceToWallLeft()
        {
            switch (snake.Heading)
            {
                case Direction.Right:
                    return world.Size.Height - snake.HeadPossition.Y - 1;
                case Direction.Left:
                    return snake.HeadPossition.Y;
                case Direction.Up:
                    return snake.HeadPossition.X;
                case Direction.Down:
                    return world.Size.Width - snake.HeadPossition.X - 1;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}