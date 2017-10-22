using System;
using System.Linq;

namespace Functional
{
    public static partial class Prelude
    {

        public static Func<T1, T2, TResult> Memoize<T1, T2, TResult>(this Func<T1, T2, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2) });

            return (arg1, arg2) =>
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2);
                    dic[key] = value;
                }

                return value;
            };
        }

        public static Func<T1, T2, T3, TResult> Memoize<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3) });

            return (arg1, arg2, arg3) =>
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3);
                    dic[key] = value;
                }

                return value;
            };
        }

        public static Func<T1, T2, T3, T4, TResult> Memoize<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4) });

            return (arg1, arg2, arg3, arg4) =>
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4);
                    dic[key] = value;
                }

                return value;
            };
        }

        public static Func<T1, T2, T3, T4, T5, TResult> Memoize<T1, T2, T3, T4,T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4), Prop5 = default(T5) });

            return (arg1, arg2, arg3, arg4, arg5) =>
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4, Prop5 = arg5 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5);
                    dic[key] = value;
                }

                return value;
            };
        }

        public static Func<T1, T2, T3, T4, T5, T6, TResult> Memoize<T1, T2, T3,T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4), Prop5 = default(T5), Prop6 = default(T6) });

            return (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4, Prop5 = arg5, Prop6 = arg6 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6);
                    dic[key] = value;
                }

                return value;
            };
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, TResult> Memoize<T1, T2,T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4), Prop5 = default(T5), Prop6 = default(T6), Prop7 = default(T7) });

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4, Prop5 = arg5, Prop6 = arg6, Prop7 = arg7 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                    dic[key] = value;
                }

                return value;
            };
        }


        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Memoize<T1,T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4), Prop5 = default(T5), Prop6 = default(T6), Prop7 = default(T7), Prop8 =
default(T8) });

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>            
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4, Prop5 = arg5, Prop6 = arg6, Prop7 = arg7, Prop8 = arg8 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                    dic[key] = value;
                }

                return value;
            };
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4), Prop5 = default(T5), Prop6 = default(T6), Prop7 = default(T7), Prop8 =
default(T8), Prop9 = default(T9) });

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>            
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4, Prop5 = arg5, Prop6 = arg6, Prop7 = arg7, Prop8 = arg8, Prop9 = arg9 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                    dic[key] = value;
                }

                return value;
            };
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4), Prop5 = default(T5), Prop6 = default(T6), Prop7 = default(T7), Prop8 =
default(T8), Prop9 = default(T9), Prop10 = default(T10) });

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>            
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4, Prop5 = arg5, Prop6 = arg6, Prop7 = arg7, Prop8 = arg8, Prop9 = arg9, Prop10 = arg10 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
                    dic[key] = value;
                }

                return value;
            };
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4), Prop5 = default(T5), Prop6 = default(T6), Prop7 = default(T7), Prop8 =
default(T8), Prop9 = default(T9), Prop10 = default(T10), Prop11 = default(T11) }
);

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>            
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4, Prop5 = arg5, Prop6 = arg6, Prop7 = arg7, Prop8 = arg8, Prop9 = arg9, Prop10 = arg10, Prop11 = arg11 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
                    dic[key] = value;
                }

                return value;
            };
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4), Prop5 = default(T5), Prop6 = default(T6), Prop7 = default(T7), Prop8 =
default(T8), Prop9 = default(T9), Prop10 = default(T10), Prop11 = default(T11),Prop12 = default(T12) });

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>            
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4, Prop5 = arg5, Prop6 = arg6, Prop7 = arg7, Prop8 = arg8, Prop9 = arg9, Prop10 = arg10, Prop11 = arg11, Prop12 = arg12 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
                    dic[key] = value;
                }

                return value;
            };
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4), Prop5 = default(T5), Prop6 = default(T6), Prop7 = default(T7), Prop8 =
default(T8), Prop9 = default(T9), Prop10 = default(T10), Prop11 = default(T11),Prop12 = default(T12), Prop13 = default(T13) });

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>            
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4, Prop5 = arg5, Prop6 = arg6, Prop7 = arg7, Prop8 = arg8, Prop9 = arg9, Prop10 = arg10, Prop11 = arg11, Prop12 = arg12, Prop13 = arg13 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
                    dic[key] = value;
                }

                return value;
            };
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4), Prop5 = default(T5), Prop6 = default(T6), Prop7 = default(T7), Prop8 =
default(T8), Prop9 = default(T9), Prop10 = default(T10), Prop11 = default(T11),Prop12 = default(T12), Prop13 = default(T13), Prop14 = default(T14) });

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>            
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4, Prop5 = arg5, Prop6 = arg6, Prop7 = arg7, Prop8 = arg8, Prop9 = arg9, Prop10 = arg10, Prop11 = arg11, Prop12 = arg12, Prop13 = arg13, Prop14 = arg14 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
                    dic[key] = value;
                }

                return value;
            };
        }

        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4), Prop5 = default(T5), Prop6 = default(T6), Prop7 = default(T7), Prop8 =
default(T8), Prop9 = default(T9), Prop10 = default(T10), Prop11 = default(T11),Prop12 = default(T12), Prop13 = default(T13), Prop14 = default(T14), Prop15 = default(T15) });

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>            
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4, Prop5 = arg5, Prop6 = arg6, Prop7 = arg7, Prop8 = arg8, Prop9 = arg9, Prop10 = arg10, Prop11 = arg11, Prop12 = arg12, Prop13 = arg13, Prop14 = arg14, Prop15 = arg15 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
                    dic[key] = value;
                }

                return value;
            };
        }

        
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Memoize<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function)
        {
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => new { Prop1 = default(T1), Prop2 = default(T2), Prop3 = default(T3), Prop4 = default(T4), Prop5 = default(T5), Prop6 = default(T6), Prop7 = default(T7), Prop8 =
default(T8), Prop9 = default(T9), Prop10 = default(T10), Prop11 = default(T11),Prop12 = default(T12), Prop13 = default(T13), Prop14 = default(T14), Prop15 = default(T15), Prop16 = default(T16) });

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>            
            {
                var value = default(TResult);

                var key = new { Prop1 = arg1, Prop2 = arg2, Prop3 = arg3, Prop4= arg4, Prop5 = arg5, Prop6 = arg6, Prop7 = arg7, Prop8 = arg8, Prop9 = arg9, Prop10 = arg10, Prop11 = arg11, Prop12 = arg12, Prop13 = arg13, Prop14 = arg14, Prop15 = arg15, Prop16 = arg16 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
                    dic[key] = value;
                }

                return value;
            };
        }

    }
}