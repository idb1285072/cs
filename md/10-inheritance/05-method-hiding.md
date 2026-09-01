# Method Hiding

## What?

- It is a concept used to hide the parent class's method by creating another method in the child class with the same name and the same parameters. The return type can be different.

## Syntax

```cs
class ParentClassName
{
  public void MethodName(param1, ...)
  {

  }
}

class ChildClassName: ParentClassName
{
  public new void MethodName(param1, ...)
  {

  }
}

parentRefVariable.MethodName(...); // parent method execute
childRefVariable.MethodName(...); // child method execute
```

## Rules

- When method hiding is done: calls through a child-typed reference execute the child method; calls through a base-typed reference execute the parent method.
- Method hiding works even without the `new` keyword; using `new` is recommended only to acknowledge the hide and suppress the compiler warning
