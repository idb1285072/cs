## What?

- Expression Tree is a collection of delegates represented in tree like structure
- Expression Tree only executes when we compile and execute it
- Expression Trees support all delegate types such as `Func`, `Action`, `Predicate` or custom delegate types

## How?

```cs
Expression<Func<type1, type2, ...>> referenceVariable;

Func<type1, type2, ...> referenceVariable2 = referenceVariable.Compile();
referenceVariable2.Invoke(arg1, arg2, ...);
```

## Example

```cs
class Student
{
  public int Id {get; set;}
  public string Name {get; set;}
  public int Age {get; set;}
}

// inside main method
Student s = new Student(){Id = 1, Name = "Raj", Age = 12}

Expression<Func<Student, bool>> expression = st => st.Age > 12 && st.Age < 20;

Func<Student, bool> myDelegate = expression.Compile();

bool result = myDelegate.Invoke(s);
```
