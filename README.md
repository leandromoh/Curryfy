# Curryfy

This project enhances usability for functions in a functional programming manner, adding the following methods: 

Curryfy is available for download and installation as
[NuGet packages](https://www.nuget.org/packages/Curryfy/1.0.0).

## Methods

### And

Transforms two or more predicates into one. Returns true if all predicates returns that. 

This method has 2 overloads.

### Applicative

Function implementation for Applicative Functor typeclass. 

This method has 2 overloads.

### Bind

Function implementation for Monad typeclass. 

This method has 2 overloads.

### Compose

Function composition.

This method has 2 overloads.

### Curry

Transforms a function with multiple arguments into a series of nested functions with one argument. 

This method has 15 overloads.

### Flip

Flip the order of first two arguments of a curried function.

Also, adds support to .NET Framework 3.5 for delegates Func and Action have more than 5 parameters.

This method has 17 overloads.

### Id

Identity function.

### Memoize

Returns a cached version of the function. 
Given the same parameters, the function returns the cached result.

### Or

Transforms two or more predicates into one. Returns true if any predicate returns that. 

This method has 2 overloads.

### Partial

Allow pass a part of the arguments of a function (or action), and returns another function that receives the rest of the arguments.  

This method has 255 overloads.

### PartialCurrying

Allow pass a part of the arguments of a function, and returns a curried function that receives the rest of the arguments.  

This method has 120 overloads.

### UnCurry

Transforms a curried function in its normal form. 

This method has 15 overloads.

### Until

Applies the generator function to the value until predicate returns true.

### Zip

Applies a specified function to the corresponding elements of N sequences, producing a sequence of the results.
It can Zip N sequences if the zipper function is curried.