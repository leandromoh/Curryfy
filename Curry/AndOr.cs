using System;
using System.Linq;
using System.Collections.Generic;

namespace Functional
{
    public static partial class Prelude
    {
        public static Func<T, bool> And<T>(this Func<T, bool> func, params Func<T, bool>[] predicates)
        {
            return And(new[] { func }.Concat(predicates));
        }

        public static Func<T, bool> And<T>(this IEnumerable<Func<T, bool>> predicates)
        {
            return t => predicates.All(f => f(t));
        }

        public static Func<T, bool> Or<T>(this Func<T, bool> func, params Func<T, bool>[] predicates)
        {
            return Or(new[] { func }.Concat(predicates));
        }

        public static Func<T, bool> Or<T>(this IEnumerable<Func<T, bool>> predicates)
        {
            return t => predicates.Any(f => f(t));
        }
    }
}