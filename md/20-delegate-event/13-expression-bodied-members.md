## What?

- Expression Bodied Members concept allows the developer to use Inline Lambda Expressions to create methods, property accessors, constructors, destructors, indexers in a class

## How?

```cs
// without return value
public ReturnType MethodName() => statement;

// with return value
public ReturnType MethodName() => AnyValue;

// constructor
public ClassName(param1) => field = param1;

// property
public type PropertyName
{
  set => field = value;
  get => field;
}
```

## Example

```cs
public class Student
{
  private string _name;
  public int GetStudentNameLength() => _name.Length;
}
```

## Rule

- Expression Bodied Members may have or parameters; may / may not have return value
- Expression Bodied Members can have only one statement
- Advantage: It provides more easier and convenient syntax to create smaller methods that performs a single calculation or condition check
