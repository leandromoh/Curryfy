using System;

namespace Curryfy
{
    //------------------------------------------------------------------------------ 
    // <auto-generated> 
    // This code was generated by a tool. 
    // 
    // Changes to this file may cause incorrect behavior and will be lost if 
    // the code is regenerated. 
    // </auto-generated> 
    //------------------------------------------------------------------------------

    public static partial class PartialSubsetActionExtensions
    { 
        // 1
        public static Action<T2, T3, T4, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1)
            => (arg2, arg3, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 2
        public static Action<T1, T3, T4, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2)
            => (arg1, arg3, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 3
        public static Action<T3, T4, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2)
            => (arg3, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 4
        public static Action<T1, T2, T4, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T3 arg3)
            => (arg1, arg2, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 5
        public static Action<T2, T4, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T3 arg3)
            => (arg2, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 6
        public static Action<T1, T4, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T3 arg3)
            => (arg1, arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 7
        public static Action<T4, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T3 arg3)
            => (arg4, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 8
        public static Action<T1, T2, T3, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T4 arg4)
            => (arg1, arg2, arg3, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 9
        public static Action<T2, T3, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T4 arg4)
            => (arg2, arg3, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 10
        public static Action<T1, T3, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T4 arg4)
            => (arg1, arg3, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 11
        public static Action<T3, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T4 arg4)
            => (arg3, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 12
        public static Action<T1, T2, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T3 arg3, T4 arg4)
            => (arg1, arg2, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 13
        public static Action<T2, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T3 arg3, T4 arg4)
            => (arg2, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 14
        public static Action<T1, T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T3 arg3, T4 arg4)
            => (arg1, arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 15
        public static Action<T5, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
            => (arg5, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 16
        public static Action<T1, T2, T3, T4, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T5 arg5)
            => (arg1, arg2, arg3, arg4, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 17
        public static Action<T2, T3, T4, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T5 arg5)
            => (arg2, arg3, arg4, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 18
        public static Action<T1, T3, T4, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T5 arg5)
            => (arg1, arg3, arg4, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 19
        public static Action<T3, T4, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T5 arg5)
            => (arg3, arg4, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 20
        public static Action<T1, T2, T4, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T3 arg3, T5 arg5)
            => (arg1, arg2, arg4, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 21
        public static Action<T2, T4, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T3 arg3, T5 arg5)
            => (arg2, arg4, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 22
        public static Action<T1, T4, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T3 arg3, T5 arg5)
            => (arg1, arg4, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 23
        public static Action<T4, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T3 arg3, T5 arg5)
            => (arg4, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 24
        public static Action<T1, T2, T3, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T4 arg4, T5 arg5)
            => (arg1, arg2, arg3, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 25
        public static Action<T2, T3, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T4 arg4, T5 arg5)
            => (arg2, arg3, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 26
        public static Action<T1, T3, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T4 arg4, T5 arg5)
            => (arg1, arg3, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 27
        public static Action<T3, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T4 arg4, T5 arg5)
            => (arg3, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 28
        public static Action<T1, T2, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T3 arg3, T4 arg4, T5 arg5)
            => (arg1, arg2, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 29
        public static Action<T2, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T3 arg3, T4 arg4, T5 arg5)
            => (arg2, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 30
        public static Action<T1, T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
            => (arg1, arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 31
        public static Action<T6> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
            => (arg6) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 32
        public static Action<T1, T2, T3, T4, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T6 arg6)
            => (arg1, arg2, arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 33
        public static Action<T2, T3, T4, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T6 arg6)
            => (arg2, arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 34
        public static Action<T1, T3, T4, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T6 arg6)
            => (arg1, arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 35
        public static Action<T3, T4, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T6 arg6)
            => (arg3, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 36
        public static Action<T1, T2, T4, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T3 arg3, T6 arg6)
            => (arg1, arg2, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 37
        public static Action<T2, T4, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T3 arg3, T6 arg6)
            => (arg2, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 38
        public static Action<T1, T4, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T3 arg3, T6 arg6)
            => (arg1, arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 39
        public static Action<T4, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T3 arg3, T6 arg6)
            => (arg4, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 40
        public static Action<T1, T2, T3, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T4 arg4, T6 arg6)
            => (arg1, arg2, arg3, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 41
        public static Action<T2, T3, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T4 arg4, T6 arg6)
            => (arg2, arg3, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 42
        public static Action<T1, T3, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T4 arg4, T6 arg6)
            => (arg1, arg3, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 43
        public static Action<T3, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T4 arg4, T6 arg6)
            => (arg3, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 44
        public static Action<T1, T2, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T3 arg3, T4 arg4, T6 arg6)
            => (arg1, arg2, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 45
        public static Action<T2, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T3 arg3, T4 arg4, T6 arg6)
            => (arg2, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 46
        public static Action<T1, T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T3 arg3, T4 arg4, T6 arg6)
            => (arg1, arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 47
        public static Action<T5> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T6 arg6)
            => (arg5) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 48
        public static Action<T1, T2, T3, T4> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T5 arg5, T6 arg6)
            => (arg1, arg2, arg3, arg4) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 49
        public static Action<T2, T3, T4> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T5 arg5, T6 arg6)
            => (arg2, arg3, arg4) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 50
        public static Action<T1, T3, T4> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T5 arg5, T6 arg6)
            => (arg1, arg3, arg4) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 51
        public static Action<T3, T4> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T5 arg5, T6 arg6)
            => (arg3, arg4) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 52
        public static Action<T1, T2, T4> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T3 arg3, T5 arg5, T6 arg6)
            => (arg1, arg2, arg4) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 53
        public static Action<T2, T4> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T3 arg3, T5 arg5, T6 arg6)
            => (arg2, arg4) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 54
        public static Action<T1, T4> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T3 arg3, T5 arg5, T6 arg6)
            => (arg1, arg4) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 55
        public static Action<T4> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T3 arg3, T5 arg5, T6 arg6)
            => (arg4) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 56
        public static Action<T1, T2, T3> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T4 arg4, T5 arg5, T6 arg6)
            => (arg1, arg2, arg3) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 57
        public static Action<T2, T3> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T4 arg4, T5 arg5, T6 arg6)
            => (arg2, arg3) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 58
        public static Action<T1, T3> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T4 arg4, T5 arg5, T6 arg6)
            => (arg1, arg3) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 59
        public static Action<T3> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T2 arg2, T4 arg4, T5 arg5, T6 arg6)
            => (arg3) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 60
        public static Action<T1, T2> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
            => (arg1, arg2) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 61
        public static Action<T2> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T1 arg1, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
            => (arg2) => function(arg1, arg2, arg3, arg4, arg5, arg6);
        
        // 62
        public static Action<T1> ApplyPartial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> function, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
            => (arg1) => function(arg1, arg2, arg3, arg4, arg5, arg6);
    }
}
