using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using SnakeBase.World;

namespace SnakeBase.Snake
{
    public abstract class BaseSnake : ISnake
    {
        protected Direction _heading;

        public Direction Heading
        {
            get
            {
                var newHeading = TryToDeterimineHeading();
                if (newHeading.HasValue)
                {
                    _heading = newHeading.Value;
                }
                return _heading;
            }
        }

        public bool IsAlive { get; protected set; } = false;

        public virtual ISnakeHead Head { get; protected set; }

        protected virtual IList<ISnakeBodyPart> Body { get; set; } = new List<ISnakeBodyPart>();

        public Location HeadPossition => Head.Possition;
        protected Location PreviousHeadPossition { get; set; }
        public virtual ICollection<Location> BodyPossition => Body.Select(t => t.Possition).ToArray();
        
        protected abstract SnakeDistanceSence distanceSence { get; set; }

        public BaseSnake()
        {
        }
        
        public virtual void Move()
        {
            if (!IsAlive)
            {
                return;
            }

            var nextDirection = TranslateDirectionAccordingToHeading(Head.Brain.DetermineNextMove());
            PreviousHeadPossition = HeadPossition.Copy();

            switch (nextDirection)
            {
                case Direction.Up:
                    MoveUp();
                    break;
                case Direction.Down:
                    MoveDown();
                    break;
                case Direction.Left:
                    MoveLeft();
                    break;
                case Direction.Right:
                    MoveRight();
                    break;
            }
            KillSnakeIfCollisionWasdetected();
        }

        protected Direction TranslateDirectionAccordingToHeading(Direction direction)
        {
            switch (Heading)
            {
                case Direction.Up:
                    return direction;
                case Direction.Down:
                    switch (direction)
                    {
                        case Direction.Up:
                            return Direction.Down;
                        case Direction.Down:
                            return Direction.Up;
                        case Direction.Left:
                            return Direction.Right;
                        case Direction.Right:
                            return Direction.Left;
                    }
                    break;
                case Direction.Left:
                    switch (direction)
                    {
                        case Direction.Up:
                            return Direction.Left;
                        case Direction.Down:
                            return Direction.Right;
                        case Direction.Left:
                            return Direction.Down;
                        case Direction.Right:
                            return Direction.Up;
                    }
                    break;
                case Direction.Right:
                    switch (direction)
                    {
                        case Direction.Up:
                            return Direction.Right;
                        case Direction.Down:
                            return Direction.Left;
                        case Direction.Left:
                            return Direction.Up;
                        case Direction.Right:
                            return Direction.Down;
                    }
                    break;
            }
            throw new InvalidOperationException();
        }

        public virtual void Grow()
        {
            var lastBodyPart = Body.Count==0 ? Head : Body.Last();
            var tailPossition = lastBodyPart.Possition;
            Body.Insert(0,new SnakeBodyPart(tailPossition.Copy()));
        }

        protected virtual void KillSnakeIfCollisionWasdetected()
        {
            if (IsAlive)
                KillSnakeIfSelfCollisionWasDetected();

            if (IsAlive)
                KillSnakeIfWallCollisionIsDetected();
        }

        protected virtual void KillSnakeIfWallCollisionIsDetected()
        {
            if (distanceSence.DidColidedWithWall())
                KillSnake();
        }

        protected virtual void KillSnakeIfSelfCollisionWasDetected()
        {
            if (Body.Any(t => t.Possition == Head.Possition))
                KillSnake();
        }

        protected virtual void KillSnake()
        {
            IsAlive = false;
        }

        protected virtual void MoveUp()
        {
            UpdateBody();
            Head.Possition.MovePoint(0,-1);
        }

        protected virtual void MoveDown()
        {
            UpdateBody();
            Head.Possition.MovePoint(0, +1);
        }

        protected virtual void MoveLeft()
        {
            UpdateBody();
            Head.Possition.MovePoint(-1, 0);
        }

        protected virtual void MoveRight()
        {
            UpdateBody();
            Head.Possition.MovePoint(1, 0);
        }

        protected virtual void UpdateBody()
        {
            if (Body.Count == 0)
                return;

            Body.Add(new SnakeBodyPart(HeadPossition.Copy()));
            Body.RemoveAt(0);
        }
        
        protected virtual Direction? TryToDeterimineHeading()
        {
            if (PreviousHeadPossition ==null)
                return Direction.Up;

            if (PreviousHeadPossition.X < HeadPossition.X)
                return Direction.Right;

            if (PreviousHeadPossition.X > HeadPossition.X)
                return Direction.Left;

            if (PreviousHeadPossition.Y > HeadPossition.Y)
                return Direction.Up;

            if (PreviousHeadPossition.Y < HeadPossition.Y)
                return Direction.Down;

            return null;
        }
        
        public virtual int CalcFitness()
        {
            var fitness = 1 + BodyPossition.Count*10;
            return fitness;
        }
        public abstract void Born(IWorld world,Location initialPossition);
    }
}
