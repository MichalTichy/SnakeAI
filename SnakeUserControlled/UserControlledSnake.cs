using System;
using System.Collections.Generic;
using System.Text;
using SnakeBase;
using SnakeBase.Snake;
using SnakeBase.World;

namespace SnakeUserControlled
{
    public class UserControlledSnake : BaseSnake
    {
        protected override ISnakeHead Head { get; }
        protected override SnakeDistanceSence distanceSence { get; }

        public UserControlledSnake(IWorld world)
        {
            Head=new UserControlledSnakeHead();
            distanceSence=new SnakeDistanceSence(world,this);
        }
    }
}
