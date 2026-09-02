## Rules

- C# provides a parameter-less constructor for every structure by default, which initializes all fields
- You can also create one or more user-defined parameterized constructors in structure.
- Each parameterized constructor must initialize all fields; otherwise it will be compiler-time error
- The new keyword used with structure, doesn't create any object / allocate any memory in heap; It is a just a syntax to call constructor of structure.

## Syntax

```cs
public StructureName(dataType parameter)
{
  field = parameter;
}
```
