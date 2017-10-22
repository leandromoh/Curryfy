using System;

namespace Functional
{
    public static partial class Prelude
    {
        public static Func<R, B> Bind<R, A, B>(this Func<R, A> func1, Func<A, Func<R, B>> func2)
        {
            return r => func2(func1(r))(r);
        }

        public static Func<Func<A, Func<R, B>>, Func<R, B>> Bind<R, A, B>(this Func<R, A> func1)
        {
            return func2 => r => func2(func1(r))(r);
        }
    }
}