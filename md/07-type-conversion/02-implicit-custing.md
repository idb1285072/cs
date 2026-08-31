
# Implicit Casting

## What?

- Lower numerical type can be autometicaly (implicitly) converted into higher numerical type.

## Refs

- `sbyte` -> `short`, `int`, `long`, `float`, `double`, `decimal`
- `byte` -> `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double` `decimal`
- `short` -> `int`, `long`, `float`, `double`, `decimal`
- `ushort` -> `int`, `uint`, `long`, `ulong`, `float`, `double`, `decimal`
- `int` -> `long`, `float`, `double`, `decimal`
- `uint` -> `long`, `ulong`, `float`, `double`, `decimal`
- `long` -> `float`, `double`, `decimal`
- `ulong` -> `float`, `double`, `decimal`
- `float` -> `double`
- `double` -> [none]
- `decimal` -> [none]
- `bool` -> [none]
- `string` -> [none]
- `char` ->
  `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double` `decimal`

## Example

```cs
sbyte a = 10;
int b;
b = a; // Implicit Casting from sbyte to int
```
