## What?

- Generic Constraints are used to specify the types allowed to be accepted in the generic type parameter

## Syntax

```cs
> where T : class
> where T : struct
> where T : ClassName // same class or it's child type
> where T : InterfaceName // same interface or it's child interface or child class
> where T : new()
```
