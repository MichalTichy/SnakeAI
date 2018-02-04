using System.Drawing;

namespace SnakeBase.Snake
{
    public class SnakeBodyPart : ISnakeBodyPart
    {
        public Location Possition { get; set; }

        public SnakeBodyPart(Location possition)
        {
            Possition = possition;
        }
    }
}
