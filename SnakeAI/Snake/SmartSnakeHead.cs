using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using SnakeAI.AI;
using SnakeBase;
using SnakeBase.Snake;

namespace SnakeAI.Snake
{
    public class SmartSnakeHead : ISnakeHead
    {
        public Point Possition { get; set; }
        public IBrain Brain { get; }

        public SmartSnakeHead(Point initialPossition, Genome genome, SnakeDistanceSence distanceSence)
        {
            Possition = initialPossition;
            Brain=new SmartSnakeBrain(genome,distanceSence);
        }
    }
}
