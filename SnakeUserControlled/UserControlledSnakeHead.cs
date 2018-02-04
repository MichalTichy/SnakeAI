using System;
using System.Collections.Generic;
using System.Text;
using SnakeBase;
using SnakeBase.Snake;
namespace SnakeUserControlled
{
    public class UserControlledSnakeHead : ISnakeHead
    {
        public Location Possition { get; }
        public IBrain Brain { get; }

        public UserControlledSnakeHead(SnakeBase.Location initiPossition)
        {
            Possition = initiPossition;
            Brain=new UserControlledSnakeBrain();
        }
    }
}
