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

    public static partial class PartialDiscardActionExtensions
    { 
        // 1
        public static Action<T2, T3, T4, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, __ arg2, __ arg3, __ arg4, __ arg5)
            => (_arg2, _arg3, _arg4, _arg5) => function(arg1, _arg2, _arg3, _arg4, _arg5);
        
        // 2
        public static Action<T1, T3, T4, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, T2 arg2, __ arg3, __ arg4, __ arg5)
            => (_arg1, _arg3, _arg4, _arg5) => function(_arg1, arg2, _arg3, _arg4, _arg5);
        
        // 3
        public static Action<T3, T4, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, T2 arg2, __ arg3, __ arg4, __ arg5)
            => (_arg3, _arg4, _arg5) => function(arg1, arg2, _arg3, _arg4, _arg5);
        
        // 4
        public static Action<T1, T2, T4, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, __ arg2, T3 arg3, __ arg4, __ arg5)
            => (_arg1, _arg2, _arg4, _arg5) => function(_arg1, _arg2, arg3, _arg4, _arg5);
        
        // 5
        public static Action<T2, T4, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, __ arg2, T3 arg3, __ arg4, __ arg5)
            => (_arg2, _arg4, _arg5) => function(arg1, _arg2, arg3, _arg4, _arg5);
        
        // 6
        public static Action<T1, T4, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, T2 arg2, T3 arg3, __ arg4, __ arg5)
            => (_arg1, _arg4, _arg5) => function(_arg1, arg2, arg3, _arg4, _arg5);
        
        // 7
        public static Action<T4, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, T2 arg2, T3 arg3, __ arg4, __ arg5)
            => (_arg4, _arg5) => function(arg1, arg2, arg3, _arg4, _arg5);
        
        // 8
        public static Action<T1, T2, T3, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, __ arg2, __ arg3, T4 arg4, __ arg5)
            => (_arg1, _arg2, _arg3, _arg5) => function(_arg1, _arg2, _arg3, arg4, _arg5);
        
        // 9
        public static Action<T2, T3, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, __ arg2, __ arg3, T4 arg4, __ arg5)
            => (_arg2, _arg3, _arg5) => function(arg1, _arg2, _arg3, arg4, _arg5);
        
        // 10
        public static Action<T1, T3, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, T2 arg2, __ arg3, T4 arg4, __ arg5)
            => (_arg1, _arg3, _arg5) => function(_arg1, arg2, _arg3, arg4, _arg5);
        
        // 11
        public static Action<T3, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, T2 arg2, __ arg3, T4 arg4, __ arg5)
            => (_arg3, _arg5) => function(arg1, arg2, _arg3, arg4, _arg5);
        
        // 12
        public static Action<T1, T2, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, __ arg2, T3 arg3, T4 arg4, __ arg5)
            => (_arg1, _arg2, _arg5) => function(_arg1, _arg2, arg3, arg4, _arg5);
        
        // 13
        public static Action<T2, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, __ arg2, T3 arg3, T4 arg4, __ arg5)
            => (_arg2, _arg5) => function(arg1, _arg2, arg3, arg4, _arg5);
        
        // 14
        public static Action<T1, T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, T2 arg2, T3 arg3, T4 arg4, __ arg5)
            => (_arg1, _arg5) => function(_arg1, arg2, arg3, arg4, _arg5);
        
        // 15
        public static Action<T5> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, __ arg5)
            => (_arg5) => function(arg1, arg2, arg3, arg4, _arg5);
        
        // 16
        public static Action<T1, T2, T3, T4> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, __ arg2, __ arg3, __ arg4, T5 arg5)
            => (_arg1, _arg2, _arg3, _arg4) => function(_arg1, _arg2, _arg3, _arg4, arg5);
        
        // 17
        public static Action<T2, T3, T4> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, __ arg2, __ arg3, __ arg4, T5 arg5)
            => (_arg2, _arg3, _arg4) => function(arg1, _arg2, _arg3, _arg4, arg5);
        
        // 18
        public static Action<T1, T3, T4> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, T2 arg2, __ arg3, __ arg4, T5 arg5)
            => (_arg1, _arg3, _arg4) => function(_arg1, arg2, _arg3, _arg4, arg5);
        
        // 19
        public static Action<T3, T4> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, T2 arg2, __ arg3, __ arg4, T5 arg5)
            => (_arg3, _arg4) => function(arg1, arg2, _arg3, _arg4, arg5);
        
        // 20
        public static Action<T1, T2, T4> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, __ arg2, T3 arg3, __ arg4, T5 arg5)
            => (_arg1, _arg2, _arg4) => function(_arg1, _arg2, arg3, _arg4, arg5);
        
        // 21
        public static Action<T2, T4> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, __ arg2, T3 arg3, __ arg4, T5 arg5)
            => (_arg2, _arg4) => function(arg1, _arg2, arg3, _arg4, arg5);
        
        // 22
        public static Action<T1, T4> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, T2 arg2, T3 arg3, __ arg4, T5 arg5)
            => (_arg1, _arg4) => function(_arg1, arg2, arg3, _arg4, arg5);
        
        // 23
        public static Action<T4> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, T2 arg2, T3 arg3, __ arg4, T5 arg5)
            => (_arg4) => function(arg1, arg2, arg3, _arg4, arg5);
        
        // 24
        public static Action<T1, T2, T3> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, __ arg2, __ arg3, T4 arg4, T5 arg5)
            => (_arg1, _arg2, _arg3) => function(_arg1, _arg2, _arg3, arg4, arg5);
        
        // 25
        public static Action<T2, T3> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, __ arg2, __ arg3, T4 arg4, T5 arg5)
            => (_arg2, _arg3) => function(arg1, _arg2, _arg3, arg4, arg5);
        
        // 26
        public static Action<T1, T3> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, T2 arg2, __ arg3, T4 arg4, T5 arg5)
            => (_arg1, _arg3) => function(_arg1, arg2, _arg3, arg4, arg5);
        
        // 27
        public static Action<T3> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, T2 arg2, __ arg3, T4 arg4, T5 arg5)
            => (_arg3) => function(arg1, arg2, _arg3, arg4, arg5);
        
        // 28
        public static Action<T1, T2> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, __ arg2, T3 arg3, T4 arg4, T5 arg5)
            => (_arg1, _arg2) => function(_arg1, _arg2, arg3, arg4, arg5);
        
        // 29
        public static Action<T2> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, T1 arg1, __ arg2, T3 arg3, T4 arg4, T5 arg5)
            => (_arg2) => function(arg1, _arg2, arg3, arg4, arg5);
        
        // 30
        public static Action<T1> ApplyPartial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> function, __ arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
            => (_arg1) => function(_arg1, arg2, arg3, arg4, arg5);
    }
}
