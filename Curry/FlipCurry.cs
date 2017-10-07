using System;

namespace Functional
{
    public static partial class Prelude
    {
        public static Func<T2, Func<T1, TResult>> Flip<T1, T2, TResult>(this Func<T1, Func<T2, TResult>> function)
        {
            return arg2 => arg1 => function(arg1)(arg2);
        }
    }
}