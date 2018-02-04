using System;

namespace SnakeAI
{
    public interface IDistanceSence
    {
        Func<int?>[] InputFunctions { get; }
    }
}