## What?

- `Predicate` is pre-defined delegate, which can be used to create events quickly, similar to `Func`
- The difference is:
  - Func must have return value of any type; Action don't have return value; Predicate must have return value of bool type
  - Func can have 0 to 16 parameters of any type; Action can have 0 to 16 parameters of any type; Predicate must have only one parameter of any type

## How?

```cs
public Predicate<Param1DataType> referenceValue;
```
