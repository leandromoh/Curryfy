using System;
using System.Linq;

namespace Functional
{
    public static partial class Prelude
    {
        private static Func<T1, TResult> MemoizeImpl<T1, TResult>(this Func<T1, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1);
                    dic[key] = value;
                }

                return value;
            };
        }

        private static Func<T1, T2, TResult> MemoizeImpl<T1, T2, TResult>(this Func<T1, T2, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, TResult> MemoizeImpl<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, TResult> MemoizeImpl<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, T5, TResult> MemoizeImpl<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4), P5 = default(T5) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4, arg5) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4, P5 = arg5 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, T5, T6, TResult> MemoizeImpl<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4), P5 = default(T5), P6 = default(T6) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4, P5 = arg5, P6 = arg6 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, T5, T6, T7, TResult> MemoizeImpl<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4), P5 = default(T5), P6 = default(T6), P7 = default(T7) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4, P5 = arg5, P6 = arg6, P7 = arg7 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> MemoizeImpl<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4), P5 = default(T5), P6 = default(T6), P7 = default(T7), P8 = default(T8) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4, P5 = arg5, P6 = arg6, P7 = arg7, P8 = arg8 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> MemoizeImpl<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4), P5 = default(T5), P6 = default(T6), P7 = default(T7), P8 = default(T8), P9 = default(T9) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4, P5 = arg5, P6 = arg6, P7 = arg7, P8 = arg8, P9 = arg9 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> MemoizeImpl<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4), P5 = default(T5), P6 = default(T6), P7 = default(T7), P8 = default(T8), P9 = default(T9), P10 = default(T10) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4, P5 = arg5, P6 = arg6, P7 = arg7, P8 = arg8, P9 = arg9, P10 = arg10 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> MemoizeImpl<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4), P5 = default(T5), P6 = default(T6), P7 = default(T7), P8 = default(T8), P9 = default(T9), P10 = default(T10), P11 = default(T11) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4, P5 = arg5, P6 = arg6, P7 = arg7, P8 = arg8, P9 = arg9, P10 = arg10, P11 = arg11 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> MemoizeImpl<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4), P5 = default(T5), P6 = default(T6), P7 = default(T7), P8 = default(T8), P9 = default(T9), P10 = default(T10), P11 = default(T11), P12 = default(T12) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4, P5 = arg5, P6 = arg6, P7 = arg7, P8 = arg8, P9 = arg9, P10 = arg10, P11 = arg11, P12 = arg12 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> MemoizeImpl<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4), P5 = default(T5), P6 = default(T6), P7 = default(T7), P8 = default(T8), P9 = default(T9), P10 = default(T10), P11 = default(T11), P12 = default(T12), P13 = default(T13) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4, P5 = arg5, P6 = arg6, P7 = arg7, P8 = arg8, P9 = arg9, P10 = arg10, P11 = arg11, P12 = arg12, P13 = arg13 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> MemoizeImpl<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4), P5 = default(T5), P6 = default(T6), P7 = default(T7), P8 = default(T8), P9 = default(T9), P10 = default(T10), P11 = default(T11), P12 = default(T12), P13 = default(T13), P14 = default(T14) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4, P5 = arg5, P6 = arg6, P7 = arg7, P8 = arg8, P9 = arg9, P10 = arg10, P11 = arg11, P12 = arg12, P13 = arg13, P14 = arg14 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> MemoizeImpl<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4), P5 = default(T5), P6 = default(T6), P7 = default(T7), P8 = default(T8), P9 = default(T9), P10 = default(T10), P11 = default(T11), P12 = default(T12), P13 = default(T13), P14 = default(T14), P15 = default(T15) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4, P5 = arg5, P6 = arg6, P7 = arg7, P8 = arg8, P9 = arg9, P10 = arg10, P11 = arg11, P12 = arg12, P13 = arg13, P14 = arg14, P15 = arg15 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
                    dic[key] = value;
                }

                return value;
            };
        }


        private static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> MemoizeImpl<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int? cacheExpirationInSeconds)
        {
            var y = new { P1 = default(T1), P2 = default(T2), P3 = default(T3), P4 = default(T4), P5 = default(T5), P6 = default(T6), P7 = default(T7), P8 = default(T8), P9 = default(T9), P10 = default(T10), P11 = default(T11), P12 = default(T12), P13 = default(T13), P14 = default(T14), P15 = default(T15), P16 = default(T16) };
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
                                   ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
                                   : (DateTime?) null;

            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
            {
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }

                var value = default(TResult);

                var key = new { P1 = arg1, P2 = arg2, P3 = arg3, P4 = arg4, P5 = arg5, P6 = arg6, P7 = arg7, P8 = arg8, P9 = arg9, P10 = arg10, P11 = arg11, P12 = arg12, P13 = arg13, P14 = arg14, P15 = arg15, P16 = arg16 };

                if (!dic.TryGetValue(key, out value))
                {
                    value = function(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
                    dic[key] = value;
                }

                return value;
            };
        }

        private static string CreateMemoizeImpl(int args)
        {
            var n = Enumerable.Range(1, args).ToArray();

            return string.Format(
@"
        private static Func<{0}, TResult> MemoizeImpl<{0}, TResult>(this Func<{0}, TResult> function, int? cacheExpirationInSeconds)
        {{
            var y = new {{ {1} }};
            var dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
            var expirationDate = cacheExpirationInSeconds.HasValue 
			                       ? DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value) 
								   : (DateTime?) null;

            return ({2}) =>
            {{
                if (expirationDate.HasValue && DateTime.Now > expirationDate.Value)
                {{
                    expirationDate = DateTime.Now.AddSeconds(cacheExpirationInSeconds.Value);
                    dic = Enumerable.Repeat(default(TResult), 0).ToDictionary(x => y);
                }}

                var value = default(TResult);

                var key = new {{ {3} }};

                if (!dic.TryGetValue(key, out value))
                {{
                    value = function({2});
                    dic[key] = value;
                }}

                return value;
            }};
        }}", string.Join(", ", n.Select(x => "T" + x).ToArray()),
             string.Join(", ", n.Select(x => string.Format("P{0} = default(T{0})", x)).ToArray()),
             string.Join(", ", n.Select(x => string.Format("arg{0}", x)).ToArray()),
             string.Join(", ", n.Select(x => string.Format("P{0} = arg{0}", x)).ToArray()));
        }
    }
}