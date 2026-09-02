# Generic Class

## What?

- Generic class is a class, which contains one or more type parameters
- You must pass any type (standard data type / structure / class) while creating object for the generic class

## Syntax

```cs
// defined generic class
class ClassName<T>
{
  public T FieldName;
}

// create object
ClassName<int> referenceVariable = new ClassName<int>();
```

## Advantage

- The same field may belong to different data types, w.r.t. different objects of the same class.
- You will decide the data type of the field, while creating the object, rather than while creating field in the class
- It helps you in code reuse, performance and type-safety
- You can create your own generic-classes, generic-methods, generic-interfaces and generic-delegates
- You can create generic collection class
  - The .NET framework class library contains many new generic collection classes in System.Collection.Generic namespace

## Rule

- The generic type parameter (T) acts as temporary data type, which represents the actual data type, provided by the user, while creating object
- You can have multiple generic type parameters in the same class (use for different fields)
- Generics are introduce in C# 2.0
