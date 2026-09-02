## What?

- Extension method is a method injected (added) into an existing class (or struct or interface), without modifying the source code of that class (or struct or interface).

## How?

```cs
// Existing Class
class ClassName
{

}

// Static class for extension method
static class ClassName
{
  public static ReturnType MethodName(this ClassName ParameterName, ...)
  {
    // method body here
  }
}
```

## Advantages

- The developer of ClassLibrary, creates a class with a set of methods
  - The consumer of ClassLibrary, can add additional methods to the same class, without modifying the source code of the ClassLibrary
- You can add additional methods to pre-defined classes / structures such as String, Int32, Console etc.

## Rules

- You must create a static class with a static method; that it will be added as a non-static method to the specified class
- This feature is introduced in C# 3.0
- The first parameter of extension must be having this keyword followed by the class name / structure name, to which you want to add the extension method.
- The parameter (with this keyword) represents the current object, just like this keyword in the instance method
- Extension method can have any number of additional parameters, where the this keyword parameter is must
- Extension method does not support method overriding. That means extension method's signature cannot be same as any existing method
- You can also add extension methods to sealed class
- Extension methods concept cannot be used to create fields, properties or events
- The static class of extension method cannot be inner class
- The namespace is which the static class of extension method is created, must be imported in order to call the extension method as non-static method.
