using System;

namespace Functional
{
    public static partial class Prelude
    {
        public static Func<T1, T3> Compose<T1, T2, T3>(this Func<T1, T2> func1, Func<T2, T3> func2)
        {
            return arg1 => func2(func1(arg1));
        }

        public static Func<Func<T2, T3>, Func<T1, T3>> Compose<T1, T2, T3>(this Func<T1, T2> func1)
        {
            return func2 => arg1 => func2(func1(arg1));
        }
    }
}