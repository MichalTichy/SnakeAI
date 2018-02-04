using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using SnakeBase.World;

namespace SnakeBase.Snake
{
    public abstract class BaseSnake : ISnake
    {
        public Direction Heading => DetermineHeading();

        public bool IsAlive { get; protected set; } = true;

        protected abstract ISnakeHead Head { get; }

        protected virtual IList<ISnakeBodyPart> Body { get; set; } = new List<ISnakeBodyPart>();

        public Point HeadPossition => Head.Possition;
        public virtual ICollection<Point> BodyPossition => Body.Select(t => t.Possition).ToArray();


        protected abstract SnakeDistanceSence distanceSence { get; }
        
        public virtual void Move()
        {

            var nextDirection = Head.Brain.DetermineNextMove();

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

        public virtual void Grow()
        {
            var tailPossition = Body.Last().Possition;
            Body.Add(new SnakeBodyPart(tailPossition));
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
            MoveLastBodyPartToHeadPossition();
            Head.Possition.Offset(0,1);
        }

        protected virtual void MoveDown()
        {
            MoveLastBodyPartToHeadPossition();
            Head.Possition.Offset(0, -1);
        }

        protected virtual void MoveLeft()
        {
            MoveLastBodyPartToHeadPossition();
            Head.Possition.Offset(-1, 0);
        }

        protected virtual void MoveRight()
        {
            MoveLastBodyPartToHeadPossition();
            Head.Possition.Offset(1, 0);
        }

        protected virtual void MoveLastBodyPartToHeadPossition()
        {
            if (Body.Count == 0)
                return;

            Body.Add(new SnakeBodyPart(HeadPossition));
            Body.RemoveAt(Body.Count-1);
        }
        
        protected virtual Direction DetermineHeading()
        {
            if (Body.Count == 0)
                return Direction.Up;

            var firstBodyPart = Body.Last();

            if (firstBodyPart.Possition.X < HeadPossition.X)
                return Direction.Right;

            if (firstBodyPart.Possition.X > HeadPossition.X)
                return Direction.Left;

            if (firstBodyPart.Possition.Y > HeadPossition.Y)
                return Direction.Down;

            if (firstBodyPart.Possition.Y < HeadPossition.Y)
                return Direction.Up;

            throw new Exception("Unable to determine snake heading");
        }
    }
}
