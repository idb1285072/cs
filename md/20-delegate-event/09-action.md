## What?

- `Action` is is pre-defined delegate, which can be used to create events quickly, similar to `Func`
- The different is
  - `Func` must have return value; `Active` don't have return value
  - `Action` must have 0 to 16 parameters

## How?

```cs
public Action<Param1DataType, Param2DataType,...> referenceVariable;
```
