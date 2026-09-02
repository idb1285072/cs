# Multiple Inheritance

## What?
- In C#, multiple inheritance is possible with interface; that means a child class can have multiple parent interfaces.

```cs
interface Interface1
{
  void Method1(param1, ...);
}
interface Interface2
{
  void Method2(param1, ...);
}
class ChildClass: Interface1, Interface2
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
c2.Method2();
```

## Rules
- One child - Multiple parent classes / parent interfaces is called as Multiple inheritance
- In C#.NET, multiple inheritance is not possible with classes; that means you cannot specify multiple parent classes
- The child class must implement all methods of all the interfaces, that are inherited from