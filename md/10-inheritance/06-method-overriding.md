# Method Overriding

## What?

- It is a concept, which is used to extended the parent class's method, by creating another method in child class with same name and same parameters.

## Syntax

```cs
class ParentClassName
{
  public virtual void MethodName(param1, ...)
  {

  }
}

class ChildClassName : ParentClassName
{
  public override void MethodName(param1, ...)
  {
    base.MethodName();
  }
}
```

## Rule
- When method overriding is done, if the method is called using child class's object; the parent class's method first and child's method executed next.
- Method Overriding is done with `virtual` keyword at parent class; and `override` keyword at child class's method.
- The parent class's method invoked using `base` keyword
- Without `virtual` keyword are parent class's method; the child class's method cannot be `override`
- The method must have same parameters and return type
- Override in child class is optional.