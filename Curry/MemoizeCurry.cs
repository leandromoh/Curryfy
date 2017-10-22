using System;
using System.Linq;

namespace Functional
{
    public static partial class Prelude
    {

        public static Func<T1, Func<T2, TResult>> Memoize<T1, T2, TResult>(this Func<T1, Func<T2, TResult>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, TResult>>> Memoize<T1, T2, T3, TResult>(this Func<T1, Func<T2, Func<T3, TResult>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> Memoize<T1, T2, T3, T4, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>> Memoize<T1, T2, T3, T4, T5, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>> Memoize<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>> Memoize<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>>> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>>> function)
        {
            return function.UnCurry().Memoize().Curry();
        }

    }
}