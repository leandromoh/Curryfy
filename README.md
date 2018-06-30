# Curryfy

Provides functional-style extensions for C#'s function type.

Version: 2.1.0

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

To use Curryfy simply import the following namespace:

```csharp
using Curryfy;
```

## Core concepts

Consider the code snippet below as part of all examples:

```csharp
Func<int, int, int, int> add = (a, b, c) => a + b + c;
```

### Partial Application

Partial application is the process of pass part of the arguments of a function, returning a function that receives the rest of the arguments.
If you provide 1 out of 3 arguments, it'll return a function that takes 2 arguments.
If you provide 2 out of 3 arguments, it'll return a function that takes 1 argument. 

This feature is available for delegates [Func](https://msdn.microsoft.com/pt-br/library/bb549151(v=vs.110).aspx) and [Action](https://msdn.microsoft.com/pt-br/library/018hxwa8(v=vs.110).aspx) through `ApplyPartial` extension method.

This method has 255 overloads.

```csharp
var add12 = add.ApplyPartial(5, 7); // add12 is Func<int, int>
var add5 = add.ApplyPartial(5);     // add5 is Func<int, int, int>
var x = add12(3) + add5(7, 3);      // 15 + 15
```

### Currying

Currying is the process of splitting a function with multiple arguments into a nested chain of one argument functions.
Therefore a curried function is a function which takes its arguments one at a time, returning a new function at each step.

This feature is available for [Func](https://msdn.microsoft.com/pt-br/library/bb549151(v=vs.110).aspx) delegates through `Curry` extension method.

This method has 15 overloads.

```csharp
var addCurried = add.Curry();   // addCurried is Func<int, Func<int, Func<int, int>>>

var add5 = addCurried(5);       // add5 is Func<int, Func<int, int>>
var add12 = add5(7);            // add12 is Func<int, int>
var x = add12(3);               // x is 15

var y = addCurried(5)(7)(3);    // y is 15
```

### UnCurrying

UnCurrying is the process of transforms a curried function in a function which takes all of its arguments at once.

This feature is available for [Func](https://msdn.microsoft.com/pt-br/library/bb549151(v=vs.110).aspx) delegates through `UnCurry` extension method.

This method has 15 overloads.

```csharp
var curried = add.Curry();            // curried is Func<int, Func<int, Func<int, int>>>
var add5 = curried(5);                // add5 is Func<int, Func<int, int>>
var uncurried = add5.UnCurry();       // uncurried is Func<int, int, int>

var x = uncurried(7, 3) + curried(5)(7)(3);    // 15 + 15
```