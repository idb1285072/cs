# Sealed Methods

## What?

- Sealed Methods must be override methods; which cannot be overridden in the corresponding child child classes
- Use sealed methods to prevent overriding that particular methods in the corresponding child classes

## Syntax

```cs
class ParentClassName
{
  public virtual void MethodName(param1, ...)
  {

  }
}

class ChildClass1: ParentClassName
{
  public sealed override void MethodName()
  {

  }
}

class ChildClass2: ChildClass1
{
  public override void MethodName() // error
  {

  }
}
```
