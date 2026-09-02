# Abstract Class

## What?

- Abstract class is a parent class, for which, we cannot create object; but we can create child classes.
- The main intention of abstract class is to provide common set of fields and methods to all of its child classes of a specific group.
- Abstract class can contain all types of members (fields, properties, methods, constructors, etc.)
- We cannot create object for abstract class; but we can access its members through child class's object.
  - So, creating child class of abstract class's is the only-way to utilize abstract class
- Use abstract class concept, for the classes, for which you feel creating object is not meaningful

## Syntax

```cs
abstract class AbstractClassName
{
  // Abstract class members here
}

class ChildClassName: AbstractClassName
{
  // child class member here
}
```
