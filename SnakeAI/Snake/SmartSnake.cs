using System;
using System.Collections.Generic;
using System.Linq;
using SnakeAI.AI;
using SnakeBase;
using SnakeBase.Snake;
using SnakeBase.World;

namespace SnakeAI.Snake
{
    public class SmartSnake:BaseSnake
    {
        public readonly Genome Genome;
        public override ISnakeHead Head { get; protected set; }
        protected override SnakeDistanceSence distanceSence { get; set; }

        public override void Born(IWorld world, Location initialPossition)
        {
            distanceSence=new SnakeDistanceSence(world,this);
            Head = new SmartSnakeHead(initialPossition, Genome, distanceSence);
            IsAlive = true;
        }

        public SmartSnake(Genome genome = null)
        {
            if (genome == null)
                genome = new Genome();

            Genome = genome;
        }
    }
}
