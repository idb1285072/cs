## What?

- The variables that are declared with var keyword are called as implicitly-typed variables (a.k.a. type-inference)
- Implicitly-typed variables are declared without specifying the type explicitly; so that the C# compiler automatically identifies the appropriate data type at compilation-time, based on the value assigned at the time of declaration

## Syntax

```cs
var x = value; // must initialization
```

## Rule

- While declaration, the type of implicitly-typed variables is fixed
  - It is not possible to change the type of that variable or assign other type of values into the implicitly typed variables, after declaration
- Implicitly typed variables can only be local variables; cannot be used for method parameters, return type or fields
- Implicitly typed variables must be initialized along with declaration
- It is not possible to declare multiple implicitly typed variables in the same statement. `var x = 10, y = 20; //error`
- It is not possible to assign null into implicitly type variable (while declaration). `var x = null //error`
