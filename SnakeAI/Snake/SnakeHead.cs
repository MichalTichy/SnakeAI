using System.Drawing;
using SnakeAI.AI;

namespace SnakeAI.Snake
{
    public class SnakeHead : SnakeBodyPart
    {
        public SnakeBrain SnakeBrain { get; set; }

        public SnakeHead(Point possition, Genome genome, SnakeDistanceSence snakeDistanceSence) : base(possition)
        {
            SnakeBrain = new SnakeBrain(genome,snakeDistanceSence);
        }


    }
}
