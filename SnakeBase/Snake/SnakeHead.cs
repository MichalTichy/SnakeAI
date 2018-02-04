using System.Drawing;

namespace SnakeBase.Snake
{
    public interface ISnakeHead : ISnakeBodyPart
    {
        IBrain Brain { get; }
    }
}
