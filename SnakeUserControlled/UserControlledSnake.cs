using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using SnakeBase;
using SnakeBase.Snake;
using SnakeBase.World;

namespace SnakeUserControlled
{
    public class UserControlledSnake : BaseSnake
    {
        public override ISnakeHead Head { get; }
        protected override SnakeDistanceSence distanceSence { get; }

        public UserControlledSnake(IWorld world,Location initialPossition)
        {
            Head=new UserControlledSnakeHead(initialPossition);
            distanceSence=new SnakeDistanceSence(world,this);
        }
    }
}
