using System;
using System.Drawing;
using System.Linq;
using SnakeBase.Snake;
using SnakeBase.World;

namespace SnakeBase
{
    public class SnakeDistanceSence : IDistanceSence
    {
        private readonly IWorld world;
        private readonly ISnake snake;

        public Func<int?> DistanceToWallAhead => CalcDistanceToWallAhead;
        public Func<int?> DistanceToWallBehind => CalcDistanceToWallBehind;
        public Func<int?> DistanceToWallRight => CalcDistanceToWallRight;
        public Func<int?> DistanceToWallLeft => CalcDistanceToWallLeft;
               
        public Func<int?> DistanceToFoodAhead => CalcDistanceToFoodAhead;
        public Func<int?> DistanceToFoodBehind => CalcDistanceToFoodBehind;
        public Func<int?> DistanceToFoodRight => CalcDistanceToFoodRight;
        public Func<int?> DistanceToFoodLeft => CalcDistanceToFoodLeft;
               
        public Func<int?> DistanceToBodyAhead => CalcDistanceToBodyAhead;
        public Func<int?> DistanceToBodyBehind => CalcDistanceToBodyBehind;
        public Func<int?> DistanceToBodyRight => CalcDistanceToBodyRight;
        public Func<int?> DistanceToBodyLeft => CalcDistanceToBodyLeft;

        public Func<int?>[] InputFunctions => new Func<int?>[]
        {
            CalcDistanceToWallAhead,
            CalcDistanceToWallBehind,
            CalcDistanceToWallRight,
            CalcDistanceToWallLeft,
            CalcDistanceToFoodAhead,
            CalcDistanceToFoodBehind,
            CalcDistanceToFoodRight,
            CalcDistanceToFoodLeft,
            CalcDistanceToBodyAhead,
            CalcDistanceToBodyBehind,
            CalcDistanceToBodyRight,
            CalcDistanceToBodyLeft
        };

        public SnakeDistanceSence(IWorld world,ISnake snake)
        {
            this.world = world;
            this.snake = snake;
        }

        public bool DidColidedWithWall()
        {
            return snake.HeadPossition.X < 0 || snake.HeadPossition.X >= world.Size.Width ||
                   snake.HeadPossition.Y < 0 || snake.HeadPossition.Y >= world.Size.Height;
        }

        #region Walls


        protected virtual int? CalcDistanceToWallBehind()
        {
            switch (snake.Heading)
            {
                case Direction.Up:
                    return world.Size.Height - snake.HeadPossition.Y - 1;
                case Direction.Down:
                    return snake.HeadPossition.Y;
                case Direction.Left:
                    return world.Size.Width - snake.HeadPossition.X - 1;
                case Direction.Right:
                    return snake.HeadPossition.X;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        protected virtual int? CalcDistanceToWallAhead()
        {
            switch (snake.Heading)
            {
                case Direction.Down:
                    return world.Size.Height - snake.HeadPossition.Y - 1;
                case Direction.Up:
                    return snake.HeadPossition.Y;
                case Direction.Right:
                    return world.Size.Width - snake.HeadPossition.X - 1;
                case Direction.Left:
                    return snake.HeadPossition.X;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        protected virtual int? CalcDistanceToWallLeft()
        {
            switch (snake.Heading)
            {
                case Direction.Left:
                    return world.Size.Height - snake.HeadPossition.Y - 1;
                case Direction.Right:
                    return snake.HeadPossition.Y;
                case Direction.Down:
                    return world.Size.Width - snake.HeadPossition.X - 1;
                case Direction.Up:
                    return snake.HeadPossition.X;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        protected virtual int? CalcDistanceToWallRight()
        {
            switch (snake.Heading)
            {
                case Direction.Right:
                    return world.Size.Height - snake.HeadPossition.Y - 1;
                case Direction.Left:
                    return snake.HeadPossition.Y;
                case Direction.Up:
                    return world.Size.Width - snake.HeadPossition.X - 1;
                case Direction.Down:
                    return snake.HeadPossition.X;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        #region Food

        protected virtual int? CalcDistanceToFoodAhead()
        {
            var isOnSameXCords = snake.HeadPossition.X == world.FoodPossition.X;
            var isOnSameYCords = snake.HeadPossition.Y == world.FoodPossition.Y;

            var xDistance = world.FoodPossition.X - snake.HeadPossition.X;
            var yDistance = world.FoodPossition.Y - snake.HeadPossition.Y;

            switch (snake.Heading)
            {
                case Direction.Up:
                    if (!isOnSameXCords || yDistance>0)
                        return null;
                    return Math.Abs(yDistance);


                case Direction.Down:
                    if (!isOnSameXCords || yDistance < 0)
                        return null;
                    return yDistance;

                case Direction.Left:
                    if (!isOnSameYCords || xDistance > 0)
                        return null;
                    return Math.Abs(xDistance);
                case Direction.Right:
                    if (!isOnSameYCords || xDistance < 0)
                        return null;
                    return xDistance;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        protected virtual int? CalcDistanceToFoodBehind()
        {
            var isOnSameXCords = snake.HeadPossition.X == world.FoodPossition.X;
            var isOnSameYCords = snake.HeadPossition.Y == world.FoodPossition.Y;

            var xDistance = world.FoodPossition.X - snake.HeadPossition.X;
            var yDistance = world.FoodPossition.Y - snake.HeadPossition.Y;

            switch (snake.Heading)
            {
                case Direction.Down:
                    if (!isOnSameXCords || yDistance>0)
                        return null;
                    return Math.Abs(yDistance);

                case Direction.Up:
                    if (!isOnSameXCords || yDistance < 0)
                        return null;
                    return yDistance;

                case Direction.Right:
                    if (!isOnSameYCords || xDistance > 0)
                        return null;
                    return Math.Abs(xDistance);
                case Direction.Left:
                    if (!isOnSameYCords || xDistance < 0)
                        return null;
                    return xDistance;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        protected virtual int? CalcDistanceToFoodLeft()
        {
            var isOnSameXCords = snake.HeadPossition.X == world.FoodPossition.X;
            var isOnSameYCords = snake.HeadPossition.Y == world.FoodPossition.Y;

            var xDistance = world.FoodPossition.X - snake.HeadPossition.X;
            var yDistance = world.FoodPossition.Y - snake.HeadPossition.Y;

            switch (snake.Heading)
            {
                case Direction.Left:
                    if (!isOnSameXCords || yDistance < 0)
                        return null;
                    return yDistance;
                case Direction.Right:
                    if (!isOnSameXCords || yDistance > 0)
                        return null;
                    return Math.Abs(yDistance);
                case Direction.Up:
                    if (!isOnSameYCords || xDistance > 0)
                        return null;
                    return Math.Abs(xDistance);
                case Direction.Down:
                    if (!isOnSameYCords || xDistance < 0)
                        return null;
                    return xDistance;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        protected virtual int? CalcDistanceToFoodRight()
        {
            var isOnSameXCords = snake.HeadPossition.X == world.FoodPossition.X;
            var isOnSameYCords = snake.HeadPossition.Y == world.FoodPossition.Y;

            var xDistance = world.FoodPossition.X - snake.HeadPossition.X;
            var yDistance = world.FoodPossition.Y - snake.HeadPossition.Y;

            switch (snake.Heading)
            {
                case Direction.Right:
                    if (!isOnSameXCords || yDistance < 0)
                        return null;
                    return yDistance;
                case Direction.Left:
                    if (!isOnSameXCords || yDistance > 0)
                        return null;
                    return Math.Abs(yDistance);
                case Direction.Down:
                    if (!isOnSameYCords || xDistance > 0)
                        return null;
                    return Math.Abs(xDistance);
                case Direction.Up:
                    if (!isOnSameYCords || xDistance < 0)
                        return null;
                    return xDistance;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        #region Body

        protected virtual int? CalcDistanceToBodyAhead()
        {
            GetDistancesFromBody(
                out var distanceToNearestRight,
                out var distanceToNearestLeft,
                out var distanceToNearestUp,
                out var distanceToNearestDown
            );


            switch (snake.Heading)
            {
                case Direction.Up:
                    return distanceToNearestUp;
                case Direction.Down:
                    return distanceToNearestDown;
                case Direction.Left:
                    return distanceToNearestLeft;
                case Direction.Right:
                    return distanceToNearestRight;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        protected virtual int? CalcDistanceToBodyBehind()
        {
            GetDistancesFromBody(
                out var distanceToNearestRight,
                out var distanceToNearestLeft,
                out var distanceToNearestUp,
                out var distanceToNearestDown
            );


            switch (snake.Heading)
            {
                case Direction.Up:
                    return distanceToNearestDown;
                case Direction.Down:
                    return distanceToNearestUp;
                case Direction.Right:
                    return distanceToNearestLeft;
                case Direction.Left:
                    return distanceToNearestRight;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        protected virtual int? CalcDistanceToBodyLeft()
        {
            GetDistancesFromBody(
                out var distanceToNearestRight,
                out var distanceToNearestLeft,
                out var distanceToNearesUp,
                out var distanceToNearestDown
            );


            switch (snake.Heading)
            {
                case Direction.Up:
                    return distanceToNearestLeft;
                case Direction.Down:
                    return distanceToNearestRight;
                case Direction.Left:
                    return distanceToNearesUp;
                case Direction.Right:
                    return distanceToNearestDown;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        protected virtual int? CalcDistanceToBodyRight()
        {
            GetDistancesFromBody(
                out var distanceToNearestRight,
                out var distanceToNearestLeft,
                out var distanceToNearestUp,
                out var distanceToNearestDown
                );


            switch (snake.Heading)
            {
                case Direction.Up:
                    return distanceToNearestRight;
                case Direction.Down:
                    return distanceToNearestLeft;
                case Direction.Left:
                    return distanceToNearestUp;
                case Direction.Right:
                    return distanceToNearestDown;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void GetDistancesFromBody(out int? distanceToNearestRight,out int? distanceToNearestLeft, out int? distanceToNearestUp,
            out int? distanceToNearestDown)
        {
            var distancesFromHead = snake.BodyPossition.Select(GetDistanceFromHead).ToArray();

            distanceToNearestRight =
                distancesFromHead.Where(t => t.HasValue)
                    .Where(t => t.Value.xDistance >= 0 && t.Value.yDistance==0)
                    .OrderBy(t => t.Value.xDistance)
                    .FirstOrDefault()?.xDistance;

            distanceToNearestLeft = distancesFromHead.Where(t => t.HasValue)
                .Where(t => t.Value.xDistance <= 0 && t.Value.yDistance == 0)
                .OrderByDescending(t => t.Value.xDistance)
                .FirstOrDefault()?.xDistance;

            if (distanceToNearestLeft.HasValue)
                distanceToNearestLeft = Math.Abs(distanceToNearestLeft.Value);

            distanceToNearestDown = distancesFromHead.Where(t => t.HasValue)
                .Where(t => t.Value.yDistance >= 0 && t.Value.xDistance == 0)
                .OrderBy(t => t.Value.yDistance)
                .FirstOrDefault()?.yDistance;

            distanceToNearestUp = distancesFromHead.Where(t => t.HasValue)
                .Where(t => t.Value.yDistance <= 0 && t.Value.xDistance == 0)
                .OrderByDescending(t => t.Value.yDistance)
                .FirstOrDefault()?.yDistance;

            if (distanceToNearestUp.HasValue)
                distanceToNearestUp = Math.Abs(distanceToNearestUp.Value);
        }

        #endregion

        protected virtual (int xDistance, int yDistance)? GetDistanceFromHead(Location location)
        {
            return (
                location.X - snake.HeadPossition.X,
                location.Y - snake.HeadPossition.Y
                );
        }
    }
}