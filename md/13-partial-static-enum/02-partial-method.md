# Partial Method

## What?

- Partial methods are declared in one partial class (just like abstract method), and implemented in another partial class, that have same name

```cs
// 1
partial class ClassName
{
  partial void MethodName(param1, ...);
}
// 2
partial class ClassName
{
  partial void MethodName(param1, ...)
  {
    // method body here
  }
}
// 3
partial class ClassName
{
  public void OtherMethod()
  {
    this.MethodName(arg1, ...); // calling the partial method
  }
}
```

## Purpose

- Assume, there are two developers; the first developer develops the first partial class; second developer develops the second partial class
- The partial method lest the first developer to declare a partial method in one partial class; and the second developer implements the partial method in the other partial class

## Rules

- Partial methods can only be created in partial class or partial structs
- Partial methods are implicitly private. It cannot have any other access modifier
- Partial methods can have only void return type
- Implementation of partial methods is optional. If there is no implementation of partial methods in any parts of the partial class, the method calls are removed by the compiler, at compilation time
- If you are building large class libraries and decide extension of methods to other developers, partial methods can be used
