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
        public override ISnakeHead Head { get; protected set; }

        public override void Born(IWorld world,Location initialPossition){
            Head = new UserControlledSnakeHead(initialPossition);
            distanceSence=new SnakeDistanceSence(world,this);
            IsAlive = true;
        }

        protected override SnakeDistanceSence distanceSence { get; set; }

        public UserControlledSnake()
        {
        }
    }
}
