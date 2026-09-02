# Interface Inheritance

## What?

- If an interface inherits from another interface, we call it as interface inheritance
- The child class that implements the child interface must implement all the members of both parent interface and child interface too.

## Example
```cs
interface Interface1
{
  void Method1(param1, ...);
}
interface Interface2: Interface1
{
  void Method2(param1, ...);
}
class ChildClass: Interface2
{
  public void Method1(param1, ...)
  {
  }
  public void Method2(param1, ...)
  {
  }
}

Interface1 c1 = new ChildClass();
c1.Method1();

Interface2 c2 = new ChildClass();
c2.Method1();
c2.Method2();
```