using System.Drawing;
using SnakeAI.AI;

namespace SnakeAI.Snake
{
    public class SnakeHead : SnakeBodyPart
    {
        public Brain Brain { get; set; }

        public SnakeHead(Point possition) : base(possition)
        {
            Brain = new Brain();
        }


    }
}
