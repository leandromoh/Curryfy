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

    public static partial class CurryfyExtensions
    { 
        // 1
        public static Func<T2, T3, TResult> ApplyPartial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function, T1 arg1)
            => (arg2, arg3) => function(arg1, arg2, arg3);
        
        // 2
        public static Func<T1, T3, TResult> ApplyPartial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function, T2 arg2)
            => (arg1, arg3) => function(arg1, arg2, arg3);
        
        // 3
        public static Func<T3, TResult> ApplyPartial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function, T1 arg1, T2 arg2)
            => (arg3) => function(arg1, arg2, arg3);
        
        // 4
        public static Func<T1, T2, TResult> ApplyPartial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function, T3 arg3)
            => (arg1, arg2) => function(arg1, arg2, arg3);
        
        // 5
        public static Func<T2, TResult> ApplyPartial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function, T1 arg1, T3 arg3)
            => (arg2) => function(arg1, arg2, arg3);
        
        // 6
        public static Func<T1, TResult> ApplyPartial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function, T2 arg2, T3 arg3)
            => (arg1) => function(arg1, arg2, arg3);
    }
}
