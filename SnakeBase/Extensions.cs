using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SnakeBase
{
    public static class Extensions
    {
        public static TSource GetRandom<TSource>(this IEnumerable<TSource> enumerable)
        {
            var rand = new Random();
            var sources = enumerable as TSource[] ?? enumerable.ToArray();
            return sources.ElementAt(rand.Next(sources.Count()));
        }
    }
}