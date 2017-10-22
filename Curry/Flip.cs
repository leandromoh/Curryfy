using System;

namespace Functional
{
    public static partial class Prelude
    {
        public static Func<T2, T1, TResult> Flip<T1, T2, TResult>(this Func<T1, T2, TResult> function)
        {
            return (arg2, arg1) => function(arg1, arg2);
        }

        public static Func<T2, T1, T3, TResult> Flip<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function)
        {
            return (arg2, arg1, arg3) => function(arg1, arg2, arg3);
        }

        public static Func<T2, T1, T3, T4, TResult> Flip<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> function)
        {
            return (arg2, arg1, arg3, arg4) => function(arg1, arg2, arg3, arg4);
        }

        public static Func<T2, T1, T3, T4, T5, TResult> Flip<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> function)
        {
            return (arg2, arg1, arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5);
        }

        public static Func<T2, T1, T3, T4, T5, T6, TResult> Flip<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> function)
        {
            return (arg2, arg1, arg3, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static Func<T2, T1, T3, T4, T5, T6, T7, TResult> Flip<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function)
        {
            return (arg2, arg1, arg3, arg4, arg5, arg6, arg7) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Func<T2, T1, T3, T4, T5, T6, T7, T8, TResult> Flip<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function)
        {
            return (arg2, arg1, arg3, arg4, arg5, arg6, arg7, arg8) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Func<T2, T1, T3, T4, T5, T6, T7, T8, T9, TResult> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function)
        {
            return (arg2, arg1, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Func<T2, T1, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function)
        {
            return (arg2, arg1, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Func<T2, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function)
        {
            return (arg2, arg1, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Func<T2, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function)
        {
            return (arg2, arg1, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Func<T2, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function)
        {
            return (arg2, arg1, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<T2, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function)
        {
            return (arg2, arg1, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T2, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function)
        {
            return (arg2, arg1, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T2, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Flip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function)
        {
            return (arg2, arg1, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }
    }
}