using System;

namespace Functional
{
    public static partial class Prelude
    {
        public static TSource Id<TSource>(TSource source)
        {
            return source;
        }
    }
}