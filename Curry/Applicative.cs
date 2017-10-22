using System;

namespace Functional
{
    public static partial class Prelude
    {
        public static Func<R, B> Applicative<R, A, B>(this Func<R, Func<A, B>> func1, Func<R, A> func2)
        {
            return r => func1(r)(func2(r));
        }

        public static Func<Func<R, A>, Func<R, B>> Applicative<R, A, B>(this Func<R, Func<A, B>> func1)
        {
            return func2 => r => func1(r)(func2(r));
        }
    }
}