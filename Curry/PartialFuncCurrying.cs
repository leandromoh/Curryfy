using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functional
{
    public static partial class Prelude
    {
        public static Func<T2, TResult> PartialCurrying<T1, T2, TResult>(this Func<T1, T2, TResult> function, T1 arg1)
        {
            return arg2 => function(arg1, arg2);
        }

        public static TResult PartialCurrying<T1, T2, TResult>(this Func<T1, T2, TResult> function, T1 arg1, T2 arg2)
        {
            return function(arg1, arg2);
        }



        public static Func<T2, Func<T3, TResult>> PartialCurrying<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => function(arg1, arg2, arg3);
        }

        public static Func<T3, TResult> PartialCurrying<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => function(arg1, arg2, arg3);
        }

        public static TResult PartialCurrying<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return function(arg1, arg2, arg3);
        }



        public static Func<T2, Func<T3, Func<T4, TResult>>> PartialCurrying<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => function(arg1, arg2, arg3, arg4);
        }

        public static Func<T3, Func<T4, TResult>> PartialCurrying<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => function(arg1, arg2, arg3, arg4);
        }

        public static Func<T4, TResult> PartialCurrying<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => function(arg1, arg2, arg3, arg4);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return function(arg1, arg2, arg3, arg4);
        }



        public static Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>> PartialCurrying<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => arg5 => function(arg1, arg2, arg3, arg4, arg5);
        }

        public static Func<T3, Func<T4, Func<T5, TResult>>> PartialCurrying<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => arg5 => function(arg1, arg2, arg3, arg4, arg5);
        }

        public static Func<T4, Func<T5, TResult>> PartialCurrying<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => arg5 => function(arg1, arg2, arg3, arg4, arg5);
        }

        public static Func<T5, TResult> PartialCurrying<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return arg5 => function(arg1, arg2, arg3, arg4, arg5);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return function(arg1, arg2, arg3, arg4, arg5);
        }



        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => arg5 => arg6 => function(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => arg5 => arg6 => function(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static Func<T4, Func<T5, Func<T6, TResult>>> PartialCurrying<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => arg5 => arg6 => function(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static Func<T5, Func<T6, TResult>> PartialCurrying<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return arg5 => arg6 => function(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static Func<T6, TResult> PartialCurrying<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return arg6 => function(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return function(arg1, arg2, arg3, arg4, arg5, arg6);
        }



        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => arg5 => arg6 => arg7 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => arg5 => arg6 => arg7 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Func<T5, Func<T6, Func<T7, TResult>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return arg5 => arg6 => arg7 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Func<T6, Func<T7, TResult>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return arg6 => arg7 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Func<T7, TResult> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return arg7 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }



        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => arg5 => arg6 => arg7 => arg8 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return arg5 => arg6 => arg7 => arg8 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Func<T6, Func<T7, Func<T8, TResult>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return arg6 => arg7 => arg8 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Func<T7, Func<T8, TResult>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return arg7 => arg8 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Func<T8, TResult> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return arg8 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }



        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return arg5 => arg6 => arg7 => arg8 => arg9 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return arg6 => arg7 => arg8 => arg9 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Func<T7, Func<T8, Func<T9, TResult>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return arg7 => arg8 => arg9 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Func<T8, Func<T9, TResult>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return arg8 => arg9 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Func<T9, TResult> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return arg9 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }



        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return arg6 => arg7 => arg8 => arg9 => arg10 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return arg7 => arg8 => arg9 => arg10 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Func<T8, Func<T9, Func<T10, TResult>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return arg8 => arg9 => arg10 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Func<T9, Func<T10, TResult>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return arg9 => arg10 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Func<T10, TResult> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return arg10 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }



        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return arg7 => arg8 => arg9 => arg10 => arg11 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return arg8 => arg9 => arg10 => arg11 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Func<T9, Func<T10, Func<T11, TResult>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return arg9 => arg10 => arg11 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Func<T10, Func<T11, TResult>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return arg10 => arg11 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Func<T11, TResult> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return arg11 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            return function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }



        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return arg8 => arg9 => arg10 => arg11 => arg12 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return arg9 => arg10 => arg11 => arg12 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Func<T10, Func<T11, Func<T12, TResult>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return arg10 => arg11 => arg12 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Func<T11, Func<T12, TResult>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return arg11 => arg12 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Func<T12, TResult> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            return arg12 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            return function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }



        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return arg9 => arg10 => arg11 => arg12 => arg13 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return arg10 => arg11 => arg12 => arg13 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<T11, Func<T12, Func<T13, TResult>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return arg11 => arg12 => arg13 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<T12, Func<T13, TResult>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            return arg12 => arg13 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<T13, TResult> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            return arg13 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            return function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }



        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return arg10 => arg11 => arg12 => arg13 => arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return arg11 => arg12 => arg13 => arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T12, Func<T13, Func<T14, TResult>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            return arg12 => arg13 => arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T13, Func<T14, TResult>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            return arg13 => arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<T14, TResult> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            return arg14 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            return function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }



        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return arg11 => arg12 => arg13 => arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            return arg12 => arg13 => arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T13, Func<T14, Func<T15, TResult>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            return arg13 => arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T14, Func<T15, TResult>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            return arg14 => arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<T15, TResult> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            return arg15 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            return function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }



        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1)
        {
            return arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2)
        {
            return arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3)
        {
            return arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            return arg12 => arg13 => arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            return arg13 => arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T14, Func<T15, Func<T16, TResult>>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            return arg14 => arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T15, Func<T16, TResult>> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            return arg15 => arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<T16, TResult> PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            return arg16 => function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static TResult PartialCurrying<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
        {
            return function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        private static string CreatePartial(int args)
        {
            if (args < 1) throw new ArgumentException("args", "args must be greater than 0");

            List<string> definitions = new List<string>();

            args++;

            for (int i = 1; i < args; i++)
            {
                var n = Enumerable.Range(1, args).ToArray();
                var ts = n.Select(x => "T" + x);
                string TsComma = ts.Join(", ");
                var letters = Enumerable.Range(1, args - 1).Select(x => "arg" + x);
                var partial = Enumerable.Range(1, args).Select(x => "T" + x + " arg" + x).Take(i);

                var templete = new StringBuilder();
                templete.Append("public static ");
                templete.Append(ts.Skip(i).AggregateRight((t1, t2) => "Func<" + t1 + ", " + t2 + ">") + " ");
                templete.Append("Partial<" + TsComma + ">");
                templete.Append("(this Func<" + TsComma + "> function," + partial.Join(", ") + ")");
                templete.Append("\n{");
                templete.Append("\n\treturn " + letters.Skip(i).Join(" => ") + " => function(" + letters.Join(", ") + ");");
                templete.Append("\n}");

                definitions.Add(templete.Replace("T" + args, "TResult").Replace("return  =>", "return ").ToString());
            }

            return definitions.Join("\n\n");
        }
    }
}