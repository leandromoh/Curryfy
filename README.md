# Curryfy

Provides functional-style extensions for C#'s function type.

Version: 3.0.0

## What and Why?

Curryfy offers strongly typed extensions that lets you take some benefits of functional programming:

* easy reuse of more abstract functions. 
* create new functions out of an existing function by fixing some parameters
* convenient way to partially apply a function

## Features

* Robust
* Self contained with no dependencies
* Easily installed through NuGet
* Supports **.NET 3.5+** and **.NET Core** (.NET Standard 2.0+)

## Installation

Simply reference Curryfy.dll and you are good to go!

Curryfy is also available via NuGet:

```
PM> Install-Package Curryfy  
```

Or visit: [https://www.nuget.org/packages/Curryfy/](https://www.nuget.org/packages/Curryfy/)

## Using the library

All helper methods are available as extension methods under the `Curryfy` namespace.  
They are divided into 5 static classes to avoid method signature ambiguities:

- `CurryExtensions` class  
Provides methods for curry and uncurry on `Func` delegates.

- `PartialIncrementalActionExtensions` and `PartialIncrementalFuncExtensions` classes  
Provides methods for partial application on `Func` and `Action` delegates, respecting parameters order.  
You can pass only the first argument, only the first and second, only the first, second and third, and so on.  
So for a delegate with `N` parameters, there are `N-1` overloads available.  
The `-1` overload not avaible is the one with all parameters, which is the delegate itself.  

- `PartialSubsetActionExtensions` and `PartialSubsetFuncExtensions` classes  
Provides methods for partial application on delegates, without respecting parameters order.  
You can pass arguments arbitrarily, regardless of its positions.  
So for a delegate with `N` parameters, there are `(2^N)-2` (2 to the power of N, minus 2) overloads available (see [powerset](https://en.wikipedia.org/wiki/Power_set)).  
The `-2` overloads not avaible are the one with no parameters and the one with all parameters, which is the delegate itself.  

## Core concepts

Consider the code snippet below as part of all examples:

```csharp
Func<int, int, int, int> add = (a, b, c) => a + b + c;
```

### [Partial Application](https://en.wikipedia.org/wiki/Partial_application)

Partial application is the process of pass part of the arguments of a function, returning a function that receives the rest of the arguments.
If you provide 1 out of 3 arguments, it'll return a function that takes 2 arguments.
If you provide 2 out of 3 arguments, it'll return a function that takes 1 argument. 

This feature is available for delegates [Func](https://msdn.microsoft.com/pt-br/library/bb549151(v=vs.110).aspx) and [Action](https://msdn.microsoft.com/pt-br/library/018hxwa8(v=vs.110).aspx) through `ApplyPartial` extension method.

This method has 1232 overloads.

```csharp
using static Curryfy.PartialIncrementalFuncExtensions;

var add12 = add.ApplyPartial(5, 7); // add12 is Func<int, int>
var add5 = add.ApplyPartial(5);     // add5 is Func<int, int, int>
var x = add12(3) + add5(7, 3);      // 15 + 15
```

Note that using the incremental approach, we can only pass the third argument after pass the first and second.  
However using the subset approach, we can pass arguments arbitrarily.  
You can pass the only first and the third arguments of a function with 5 parameters, for example.  

```csharp
using static Curryfy.PartialSubsetFuncExtensions;

var add3 = add.ApplyPartial(arg3: 3);   // parameter c receives 3
var add10 = add3.ApplyPartial(arg2: 7); // parameter b receives 7
var x = add10(5);                       // parameter a receives 5
Console.WriteLine(x);                   // x = 15
```


### [Currying](https://en.wikipedia.org/wiki/Currying)

Currying is the process of splitting a function with multiple arguments into a nested chain of one argument functions.
Therefore a curried function is a function which takes its arguments one at a time, returning a new function at each step.

This feature is available for [Func](https://msdn.microsoft.com/pt-br/library/bb549151(v=vs.110).aspx) delegates through `Curry` extension method.

This method has 15 overloads.

```csharp
using static Curryfy.CurryExtensions;

var addCurried = add.Curry();   // addCurried is Func<int, Func<int, Func<int, int>>>

var add5 = addCurried(5);       // add5 is Func<int, Func<int, int>>
var add12 = add5(7);            // add12 is Func<int, int>
var x = add12(3);               // x is 15

var y = addCurried(5)(7)(3);    // y is 15
```

### [UnCurrying](https://en.wikipedia.org/wiki/Currying)

UnCurrying is the process of transforms a curried function in a function which takes all of its arguments at once.

This feature is available for [Func](https://msdn.microsoft.com/pt-br/library/bb549151(v=vs.110).aspx) delegates through `UnCurry` extension method.

This method has 15 overloads.

```csharp
using static Curryfy.CurryExtensions;

var curried = add.Curry();            // curried is Func<int, Func<int, Func<int, int>>>
var add5 = curried(5);                // add5 is Func<int, Func<int, int>>
var uncurried = add5.UnCurry();       // uncurried is Func<int, int, int>

var x = uncurried(7, 3) + curried(5)(7)(3);    // 15 + 15
```

## Use this library? Give us some feedback :speech_balloon:
If you use this library for learning, commercial development, or something else, please give us some feedback!  
Open a new issue and describe your experience, latter we will have a "users feedback" section.
