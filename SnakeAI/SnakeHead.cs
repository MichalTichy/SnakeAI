using System.Drawing;

namespace SnakeAI
{
    public class SnakeHead : SnakeBodyPart
    {
        public SnakeBrain Brain { get; set; }

        public SnakeHead(Point possition) : base(possition)
        {
            Brain = new SnakeBrain();
        }


    }
}
