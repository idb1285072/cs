## What?

- Dynamically Typed Variables are the variables that are declared with `dynamic` keyword
- Declared without specifying the type explicitly
- There is no fixed type of value to these variables
- C# compiler skips type-checking at compilation time; instead, it resolves the data types of its values, at run time.

## Syntax

```cs
dynamic variableName = value;
```

## Example

```cs
dynamic x;
x = 100;
x = "Hello";
x = new Student();
```

## Rule

- The `dynamic` type variables are converted as object type in most cases
  - `dynamic x = 100;` -> `object x = 100;`
- The Dynamically typed variable can change its data type, any number of times, at runtime
- Methods and other members of dynamically typed variables will not be checked by the compiler at compilation time; will be checked by CLR at run time
  - If the method or other member not available, it would not cause compile-time error; it raises run-time-error, when the execution flow encountered that particular statement
  - `dynamicVariable.NonExistingMethod(); // run-time error`
- The dynamically typed variables need not be initialized, while declaration
- The dynamically typed variable doesn't have intellisense in Visual Studio
- Type dynamic keyword is allowed for local variables, method parameters, fields, property, return types etc.
