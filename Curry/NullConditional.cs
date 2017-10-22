using System;

namespace Functional
{
    public static partial class Prelude
    {
        static TResult? NullConditionals<TSource, TResult>(this TSource? source, Func<TSource, TResult?> selector)
            where TResult : struct
            where TSource : struct
        {
            return source == null ? (TResult?)null : selector(source.Value);
        }

        static TResult NullConditional<TSource, TResult>(this TSource? source, Func<TSource, TResult> selector)
            where TSource : struct
            where TResult : class
        {
            return source == null ? null : selector(source.Value);
        }

        static TResult? NullConditionals<TSource, TResult>(this TSource source, Func<TSource, TResult> selector)
            where TSource : class
            where TResult : struct
        {
            return source == null ? null : (TResult?) selector(source);
        }

        static TResult? NullConditionals<TSource, TResult>(this TSource source, Func<TSource, TResult?> selector)
            where TSource : class
            where TResult : struct
        {
            return source == null ? null : selector(source);
        }

        static TResult NullConditional<TSource, TResult>(this TSource source, Func<TSource, TResult> selector)
            where TSource : class
            where TResult : class
        {
            return source == null ? null : selector(source);
        }
    }
}