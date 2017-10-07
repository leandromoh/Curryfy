using System;

namespace Functional
{
    public static partial class Prelude
    {
        public static Func<T1, T2, TResult> UnCurry<T1, T2, TResult>(this Func<T1, Func<T2, TResult>> function)
        {
            return (arg1, arg2) => function(arg1)(arg2);
        }

        public static Func<T1, T2, T3, TResult> UnCurry<T1, T2, T3, TResult>(this Func<T1, Func<T2, Func<T3, TResult>>> function)
        {
            return (arg1, arg2, arg3) => function(arg1)(arg2)(arg3);
        }

        public static Func<T1, T2, T3, T4, TResult> UnCurry<T1, T2, T3, T4, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> function)
        {
            return (arg1, arg2, arg3, arg4) => function(arg1)(arg2)(arg3)(arg4);
        }

        public static Func<T1, T2, T3, T4, T5, TResult> UnCurry<T1, T2, T3, T4, T5, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>> function)
        {
            return (arg1, arg2, arg3, arg4, arg5) => function(arg1)(arg2)(arg3)(arg4)(arg5);
        }

        public static Func<T1, T2, T3, T4, T5, T6, TResult> UnCurry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>> function)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6) => function(arg1)(arg2)(arg3)(arg4)(arg5)(arg6);
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, TResult> UnCurry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>> function)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => function(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7);
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> UnCurry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>> function)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => function(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8);
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> UnCurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>> function)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => function(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9);
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> UnCurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>> function)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => function(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10);
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> UnCurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>> function)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => function(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10)(arg11);
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> UnCurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>> function)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => function(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10)(arg11)(arg12);
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> UnCurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>> function)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => function(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10)(arg11)(arg12)(arg13);
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> UnCurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>> function)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => function(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10)(arg11)(arg12)(arg13)(arg14);
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> UnCurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>> function)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => function(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10)(arg11)(arg12)(arg13)(arg14)(arg15);
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> UnCurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>>> function)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => function(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10)(arg11)(arg12)(arg13)(arg14)(arg15)(arg16);
        }
    }
}