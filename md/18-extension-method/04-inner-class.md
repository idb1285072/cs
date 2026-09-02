## What?

- Inner Class (a.k.a. Nested Class) is a class, which is created in another class (outer-class or containing class)

## Syntax

```cs
class ClassName
{
  class InnerClassName
  {
    // member here
  }
}

// access
ClassName.InnerClassName;
```

## Advantage

- We can create all inter-related classes of a class, inner classes

## Rule

- Inner class cannot access the members of outer class directly, without object
- You are allowed to create objects of inner class in outer class; and vice versa; but you cannot do both; if you create objects vice-versa, it causes StackOverflowException
- You can create a child class for the inner class, outside the outer class
