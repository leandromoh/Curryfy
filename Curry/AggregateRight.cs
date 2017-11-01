using System;
using System.Linq;
using System.Collections.Generic;

namespace Functional
{
    public static partial class Prelude
    {
        private static TSource AggregateRight<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (func == null) throw new ArgumentNullException("func");
            if (!source.Any()) throw new InvalidOperationException("Sequence contains no elements");

            IList<TSource> e = (source as IList<TSource>) ?? source.ToArray();

            return AggregateRightImp(e, e.Last(), func, e.Count - 1);
        }

        private static TResult AggregateRightImp<TSource, TResult>(IList<TSource> e, TResult current, Func<TSource, TResult, TResult> func, int i)
        {
            while (i-- > 0)
            {
                current = func(e[i], current);
            }

            return current;
        }

        private static string Join(this IEnumerable<string> sequence, string separetor)
        {
            return string.Join(separetor, sequence.ToArray());
        }
    }
}