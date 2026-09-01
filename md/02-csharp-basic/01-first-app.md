## Syntax:

```cs
class ClassName
{
  static void Main()
  {

  }
}
```

- ClassName
  - Every C# program must contain at least one class.
  - ClassName can differ from FileName.
  - The ClassName can be whatever for Main method.
- Main Method
  - **Starting Point** (C# Compiler look for Main method)
  - case-sensitive (M is uppercase)
  - must be **static** method (**The program must be able to start without creating an object**)
  - **Return Type:** `void`, `int`, `Task`, or `Task<int>`.
    - `void` → The method does not return a value.
    - `int` → The method returns an integer value. For an application entry point, the returned integer can be passed to the Operating System as the program's exit code.
      - `0` → Typically indicates successful execution.
      - A non-zero value (such as `1`) → Typically indicates an error or unsuccessful execution.
    - `Task` → Represents an asynchronous operation that does not return a value.
    - `Task<int>` → Represents an asynchronous operation that returns an `int` value.
- Entry Point
  - A C# executable application normally has **one entry point**. **Main Method** is the entry point by default.
  - If multiple valid entry points exist, the compiler requires you to specify which one should be used.

## Just to know

- Project = collection of files
- Solution = collection of projects
