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
  - **starting point** (C# Compiler look for Main method)
  - case-sensitive (M is uppercase)
  - must be **static** method (The program must be able to start without creating an object)
  - return type `void`, `int`, `Task`, `Task<int>` (if return int, it will return to the Operating System. if return 0 to Operating System, indicate program execute successfully. if return 1 to Operating System, indicate the program has some error.)
- Only 1 entry point
- Project is collection of file
