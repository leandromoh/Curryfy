# Curryfy

This project enhances usability for functions in a functional programming manner, adding the following methods: 

Curryfy is available for download and installation as
[NuGet packages](https://www.nuget.org/packages/Curryfy/).

## Methods

### And

Transforms two or more predicates into one. Returns true if all predicates does. 

This method has 2 overloads.

### Applicative

Function implementation for Applicative Functor typeclass. 

This method has 2 overloads.

### Bind

Function implementation for Monad typeclass. 

This method has 2 overloads.

### Compose

Function (implementation for Functor typeclass) composition.
Receives a function that receives A and returns B and a function that receives B and returns C
And then returns a function that receives A and returns C.

This method has 2 overloads.

### Curry

Transforms a function with multiple arguments into a series of nested functions with one argument. 

This method has 15 overloads.

### Flip

Flip the order of first two arguments of a curried function.

This method has 17 overloads.

### Id

Identity function.
This function returns the value which it was passed to it, replacing the "x => x" lambda.

### Memoize

Returns a function that wraps a function. 
Each time the resulting function is called with a new value, its result is memoized (cached).
Subsequent calls use the memoized value. 

This method has 45 overloads.

### NullConditional[s]

Used to test for null before performing an operation over an object (like member access or method invoke).
This is the functional version of the "Null-conditional Operator" (?.), introduced in C# 6.
To avoid ambiguity for the compiler, was added the letter "s" at the end of NullConditional function when the operation returns a value type.

This method has 5 overloads.

### Or

Transforms two or more predicates into one. Returns true if any predicate does. 

This method has 2 overloads.

### Partial

Allow pass a part of the arguments of a function (or action), and returns another function that receives the rest of the arguments.  

This method has 255 overloads.

### PartialCurrying

Allow pass a part of the arguments of a function, and returns a curried function that receives the rest of the arguments.  

This method has 120 overloads.

### TryGetData

Try to invoke a function, at most the specified number of times, until it returns a valid result.
When it exceed the maximum amount of tries, the fall back function is invoked.

### UnCurry

Transforms a curried function in its normal form. 

This method has 15 overloads.

### Until

Applies the generator function to the value until predicate returns true.

### Zip

Applies a specified function to the corresponding elements of N sequences, producing a sequence of the results.
It can Zip N sequences if the zipper function is curried.

This method has 2 overloads.