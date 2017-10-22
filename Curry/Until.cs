using System;

namespace Functional
{
    public static partial class Prelude
    {
        public static TSource Until<TSource>(this Func<TSource, bool> predicate, Func<TSource, TSource> generator, TSource source)
        {
            while (!predicate(source))
            {
                source = generator(source);
            }

            return source;
        }
    }
}