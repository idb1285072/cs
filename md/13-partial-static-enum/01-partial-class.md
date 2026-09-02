# Partial Class

## What?

- Partial class is a class that splits into multiple files
- Each file is treated as a part of the class

```cs
// File1.cs
partial class ClassName
{
  member1;
}
// File2.cs
partial class ClassName
{
  member2;
}
// Complied Source Code
class ClassName
{
  member1;
  member2;
}
```

## Rule

- At compilation time, all partial classes that have same name, become as a single class
- All the partial classes (that want to be a part of a class) should have same name and should be in the same namespace and same assembly & should same access-modifier (such as `internal` or `public`)
- Duplicate members are not allowed in partial classes
- Any attributes / modifiers (such as abstract, sealed) applied on one partial class, will be applied to all partial classes that have same name.
- The `partial` keyword can be used only at before the keywords `class`, `struct`, `interface` and `void`

## Advantage

- Each partial class can be developed individually, by different developers / teams
- In WinForms / WebForms, the Designer-generated code will be kept in one partial class; the code written by developer will be kept in another partial class with same name; so both become as a single class at compilation time
