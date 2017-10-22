using System;
using System.Linq;
using System.Collections.Generic;

namespace Functional
{
    public static partial class Prelude
    {
        public static IEnumerable<TResult> Zip<TSource, TResult>(this Func<TSource, TResult> function, IEnumerable<TSource> values)
        {
            return values.Select(function);
        }

        public static IEnumerable<TResult> Zip<TSource, TResult>(this IEnumerable<Func<TSource, TResult>> functions, IEnumerable<TSource> values)
        {
            return functions.Zip(values, (f, x) => f(x));
        }
    }
}