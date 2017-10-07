using System;

namespace Functional
{
    public static partial class Prelude
    {
        public static void Partial<T1>(this Action<T1> action, T1 arg1)
        {
            action(arg1);
        }

        public static Action<T2> Partial<T1, T2>(this Action<T1, T2> action, T1 arg1)
        {
            return (arg2) => action(arg1, arg2);
        }

        public static void Partial<T1, T2>(this Action<T1, T2> action, T1 arg1, T2 arg2)
        {
            action(arg1, arg2);
        }



        public static Action<T2, T3> Partial<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1)
        {
            return (arg2, arg3) => action(arg1, arg2, arg3);
        }

        public static Action<T3> Partial<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2)
        {
            return (arg3) => action(arg1, arg2, arg3);
        }

        public static void Partial<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
        {
            action(arg1, arg2, arg3);
        }



        public static Action<T2, T3, T4> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1)
        {
            return (arg2, arg3, arg4) => action(arg1, arg2, arg3, arg4);
        }

        public static Action<T3, T4> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2)
        {
            return (arg3, arg4) => action(arg1, arg2, arg3, arg4);
        }

        public static Action<T4> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4) => action(arg1, arg2, arg3, arg4);
        }

        public static void Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            action(arg1, arg2, arg3, arg4);
        }



        public static Action<T2, T3, T4, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        }

        public static Action<T3, T4, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2)
        {
            return (arg3, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        }

        public static Action<T4, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        }

        public static Action<T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5) => action(arg1, arg2, arg3, arg4, arg5);
        }

        public static void Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            action(arg1, arg2, arg3, arg4, arg5);
        }



        public static Action<T2, T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static Action<T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2)
        {
            return (arg3, arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static Action<T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static Action<T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static Action<T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static void Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            action(arg1, arg2, arg3, arg4, arg5, arg6);
        }



        public static Action<T2, T3, T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6, arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Action<T3, T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2)
        {
            return (arg3, arg4, arg5, arg6, arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Action<T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4, arg5, arg6, arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Action<T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5, arg6, arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Action<T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (arg6, arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Action<T7> Partial<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static void Partial<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }



        public static Action<T2, T3, T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6, arg7, arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Action<T3, T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2)
        {
            return (arg3, arg4, arg5, arg6, arg7, arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Action<T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4, arg5, arg6, arg7, arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Action<T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5, arg6, arg7, arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Action<T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (arg6, arg7, arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Action<T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (arg7, arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Action<T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return (arg8) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static void Partial<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }



        public static Action<T2, T3, T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Action<T3, T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2)
        {
            return (arg3, arg4, arg5, arg6, arg7, arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Action<T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4, arg5, arg6, arg7, arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Action<T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5, arg6, arg7, arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Action<T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (arg6, arg7, arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Action<T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (arg7, arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Action<T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return (arg8, arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Action<T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return (arg9) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static void Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }



        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Action<T3, T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2)
        {
            return (arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Action<T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4, arg5, arg6, arg7, arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Action<T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5, arg6, arg7, arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Action<T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (arg6, arg7, arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Action<T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (arg7, arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Action<T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return (arg8, arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Action<T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return (arg9, arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Action<T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return (arg10) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static void Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }



        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2)
        {
            return (arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Action<T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Action<T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5, arg6, arg7, arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Action<T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (arg6, arg7, arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Action<T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (arg7, arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Action<T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return (arg8, arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Action<T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return (arg9, arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Action<T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return (arg10, arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Action<T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return (arg11) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static void Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }



        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2)
        {
            return (arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Action<T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Action<T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (arg6, arg7, arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Action<T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (arg7, arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Action<T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return (arg8, arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Action<T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return (arg9, arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Action<T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return (arg10, arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Action<T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return (arg11, arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Action<T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            return (arg12) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static void Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }



        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2)
        {
            return (arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Action<T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Action<T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (arg7, arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Action<T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return (arg8, arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Action<T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return (arg9, arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Action<T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return (arg10, arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Action<T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return (arg11, arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Action<T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            return (arg12, arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Action<T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            return (arg13) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static void Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }



        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2)
        {
            return (arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Action<T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Action<T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return (arg8, arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Action<T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return (arg9, arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Action<T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return (arg10, arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Action<T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return (arg11, arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Action<T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            return (arg12, arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Action<T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            return (arg13, arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Action<T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            return (arg14) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static void Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }



        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1)
        {
            return (arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2)
        {
            return (arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return (arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return (arg9, arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return (arg10, arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return (arg11, arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            return (arg12, arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
        {
            return (arg13, arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
        {
            return (arg14, arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Action<T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
        {
            return (arg15) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static void Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
        {
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

    }
}