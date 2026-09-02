## Syntax

```cs
namespace System
{
  class Object
  {
    virtual bool Equals(object value);
    virtual int GetHashCode();
    Type GetType();
    virtual string ToString();
  }
}
```

## Rule

- `bool Equals(object value)`
  - Compares the current object with the given argument object; return true, if both are same object; return false, if both are different objects.
- `int GetHashCode(object value)`
  - Returns the a number that represents the object. It is not guarantee that the hash code is unique by default
- `Type GetType()`
  - Returns the name of the class (including namespace path), based on which, the object is created
- `string ToString()`
  - By default, it returns the name of the class (including namespace path), based on which, the object is created
  - It is virtual method, which can be overridden in the child class
