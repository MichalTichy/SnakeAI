using System.Drawing;

namespace SnakeBase.Snake
{
    public class SnakeBodyPart : ISnakeBodyPart
    {
        public Point Possition { get; set; }

        public SnakeBodyPart(Point possition)
        {
            Possition = possition;
        }
    }
}
