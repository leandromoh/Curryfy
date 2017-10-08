# Curryfy

This project enhances usability for functions in a functional programming manner, adding the following methods: 

Curryfy is available for download and installation as
[NuGet packages](https://www.nuget.org/packages/Curryfy/1.0.0).

## Methods

### Curry

Transforms a function with multiple arguments into a series of nested functions with one argument. 

This method has 15 overloads.

### UnCurry

Transforms a curried function in its normal form. 

This method has 15 overloads.

### Partial

Allow pass a part of the arguments of a function (or action), and returns another function that receives the rest of the arguments.  

This method has 255 overloads.

### PartialCurrying

Allow pass a part of the arguments of a function, and returns a curried function that receives the rest of the arguments.  

This method has 120 overloads.

### Flip

Flip the order of first two arguments of a curried function.

Also, adds support to .NET Framework 3.5 for delegates Func and Action have more than 5 parameters.
