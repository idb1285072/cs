# Parameter Modifier

## What?

- Specifies how the parameter receives a value

## List

- Default (No Keyword)
- `ref`
- `out`
- `in`
- `params`

## Syntax

```cs
AccessModifier Modifier ReturnDataType MethodName(
  ParameterModifier DataType Parameter1,
  ...)
{

}
```

# Default

- The Argument will be assigned into the Parameter but not reverse.

## Example

```cs
public void ChangeValue(int x)
{
  x = 30;
}
int y = 20;
ChangeValue(ref y);
System.Console.WriteLine(y) // 20
```

# `ref`

- The argument will be assigned into the parameter and vice versa.
- The argument must be a variable and must be **pre-initialized**

## Example

```cs
public void ChangeValue(ref int x)
{
  x = 30;
}

int y = 20;
ChangeValue(ref y);
System.Console.WriteLine(y) // 30
```

# `out`

- The argument will not be assigned into the parameter but only reverse
- The argument must be a variable, the argument can be un-initialized
- if not assign value of the out parameter in side method body, it will be compile time error
- more than one value return

## Example

```cs
public void ChangeValue(out int x)
{
  x = 30;
}

int y;
ChangeValue(out y);
System.Console.WriteLine(y) // 30
```

## out variable declaration

- You can declare out variable directly while calling the method with out parameter.
- New feature in C# 7.0.

```cs
public void ChangeValue(out int x)
{
  x = 30;
}

ChangeValue(out int y);
System.Console.WriteLine(y) // 30
```

# `in`

- The argument will be assigned into the parameter, but the parameter becomes **readonly**.
- We cannot modify the value of parameter in the method; if you try to change, compile-time error will be shown.
- New feature of C# 7.2

```cs
// Method Definition
AccessModifier Modifier ReturnType MethodName(in DataType parameter1, ...)
{
  ...
  parameter1 = value; // error, we cannot change teh value of parameter
}

// Method Calling
MethodName(in argument1, ...);
```

# `ref` return

- The reference of return variable will be assigned to receiving variable
- New feature in C# 7.3.

```cs
// Method Definition
AccessModifier Modifier ref ReturnDataTye MethodName(Parameters)
{
  return ref variable;
}

// Method Calling
ref variable = ref MethodName(Arguments)
```

```cs
public class Student {
  public int grade = 3;

  public void PrintGrade()
  {
    System.Console.WriteLine("Grade: " + grade);
  }

  public ref int DoWork()
  {
    return ref grade;
  }
}

class Program
{
  static void Main()
  {
    Student s = new Student();
    s.PrintGrade(); // 3
    ref int g = ref s.DoWork();
    g = 5;
    s.PrintGrade(); // 5
    System.Console.ReadKey();
  }
}
```

# `params`

## What?

- All the set of arguments will be at-a-time received as an array into the parameter.
- The params parameter modifier can be used only for the last parameter of the method; and can be used only once for one method

## Syntax

```cs
AccessModifier modifier ReturnDataType MethodName(params DataType[] Parameter1, ...)
{
  //...
  Parameter1[index]
}
```

## Example

```cs
class Student
{
  public void DisplaySubject(
    params string[] subjects)
  {
    for(int i = 0; i < subjects.length; i++)
  {
    System.Console.WriteLine(subjects[i]);
  }
  }
}

class Program
{
  static void Main()
  {
    Student s = new Student();
    s.DisplaySubjects(
      "Theory of Computation",
      "Computer Networks",
      "Discrete Mathematics",
      "Digital System Design");
  }
}
```
