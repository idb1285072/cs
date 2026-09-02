# Polymorphism

## What

- Polymorphism provides the ability to the developer, to define different implements for the same method in the same class or different classes

## Two Types of Polymorphism

- Compile-Time Polymorphism
  - Method Overloading
  - Decision will be taken at compilation time
  - also known as Early Binding / Static Polymorphism
- Run-Time Polymorphism
  - Method Overriding
  - Decision will be taken at run time
  - Also known as Late Binding / Dynamic Polymorphism

## Implementation

```cs
// method overriding
public void Add(int a, int b);
public void Add(int a, int b, int c);

// method overloading
abstract class ParentClass
{
  public abstract void Add(int a, int b);
}

class ChildClass1: ParentClass
{
  public override void Add(int a, int b)
  {
  }
}
class ChildClass2: ParentClass
{
  public override void Add(int a, int b)
  {
  }
}

ParentClass c1;
c1 = new ChildClass1();
c1.Add(10, 20); // calls ChildClass1.Add
c1 = new ChildClass2();
c1.Add(10, 20); // calls ChildClass2.Add
```
