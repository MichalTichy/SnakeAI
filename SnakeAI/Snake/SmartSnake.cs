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
        public override ISnakeHead Head { get; }
        protected sealed override SnakeDistanceSence distanceSence { get; }

        public SmartSnake(Location initialPossition,IWorld world,Genome genome)
        {
            distanceSence=new SnakeDistanceSence(world,this);
            Head=new SmartSnakeHead(initialPossition,genome,distanceSence);
        }
    }
}
