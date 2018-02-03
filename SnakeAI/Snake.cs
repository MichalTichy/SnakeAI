using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SnakeAI
{
    public class Snake : ISnake
    {
        public Direction Heading => DetermineHeading();

        public bool IsAlive { get; protected set; } = true;

        protected SnakeHead Head;
        public Point HeadPossition => Head.Possition;

        protected IList<SnakeBodyPart> Body;

        protected readonly World world;
        
        public Snake(Point initialPossition, World world)
        {
            this.world = world;
            Head = new SnakeHead(initialPossition);
            Body = new List<SnakeBodyPart>();
        }

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
            if (Head.Possition.X < 0 || Head.Possition.X > world.Size.Width ||
                Head.Possition.Y < 0 || Head.Possition.Y > world.Size.Height)
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
