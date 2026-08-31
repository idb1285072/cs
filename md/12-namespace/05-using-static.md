# `using static`

## What?

- access the static members of a class directly without specifying the class name

## How?

```cs
// instead of
Math.Sqrt(25);
Math.PI;
System.Console.WriteLine();

// using static
using static System.Console;
using static System.Math;

Sqrt(25);
PI;
WriteLine();
```
