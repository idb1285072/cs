# Local Function

## What?

- Local Functions are functions, to do some small process, which is written inside a method.
- Local function are not part of the class; they can't be called directly through reference variable.
- Local functions don't support access modifiers and modifiers
- Local functions support parameters and return

## Why?

- Reusability

## Syntax

```cs
public void MethodName(param1, param2, ...)
{
  LocalFunctionName();

  ReturnDataType LocalFunctionName(param1, param2, ...)
  {
    // Local Function Body Here
  }
}
```

## Example

```cs
class Student
{
  public void DisplayMarks(int marks1, int marks2, int marks3){
    System.Console.WriteLine("Marks 1: " + marks1);
    System.Console.WriteLine("Marks 2: " + marks2);
    System.Console.WriteLine("Marks 3: " + marks3);
    System.Console.WriteLine("Average Marks: " + getAvgMarks());

    double getAvgMarks()
    {
      double avg;
      avg = (double)(marks1 + marks2 + marks3) / 3;
      return avg;
    }
  }
}

class Program
{
  static void Main(){
    Student s = new Student();
    s.DisplayMarks();
    System.Console.Readkey();
  }
}
```

# Static Local Function

## What?

- Static Local Functions are functions, same as normal Local Functions
- Only the difference is, static local function **cannot access local variables or parameters of containing method**
- This is to avoid accidental access of local variables or parameters of containing method, inside the local function.

## Syntax:

```cs
public void MethodName(param1, param2, ...){
  LocalFunctionName(); // Calling the Local Function

  static ReturnDataType LocalFunctionName(param1, param2, ...){
    // cannot access local variables or parameters of containing method.
  }
}
```

## Example

```cs
class Student
{
  public void DisplayMarks(int marks1, int marks2, int marks3){
    System.Console.WriteLine("Marks 1: " + marks1);
    System.Console.WriteLine("Marks 2: " + marks2);
    System.Console.WriteLine("Marks 3: " + marks3);
    System.Console.WriteLine("Average Marks: " + getAvgMarks(marks1, marks2, marks3));

    static double getAvgMarks(int m1, int m2, int m3)
    {
      double avg;
      // avg = (double)(marks1 + marks2 + marks3) / 3;
      avg = (double) (m1 + m2 + m3) / 3;
      return avg;
    }
  }
}

class Program
{
  static void Main(){
    Student s = new Student();
    s.DisplayMarks();
    System.Console.Readkey();
  }
}
```

## Change C# Version

```cs
<TargetFrameworkVersion>4.8</TargetFrameworkVersion>
<LangVersion>9.0</LangVersion>
```
