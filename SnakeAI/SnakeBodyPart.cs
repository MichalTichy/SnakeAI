using System.Drawing;

namespace SnakeAI
{
    public class SnakeBodyPart
    {
        public Point Possition { get; set; }

        public SnakeBodyPart(Point possition)
        {
            Possition = possition;
        }
    }
}
