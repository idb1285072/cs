
# Explicit Casting

## What?

- We can manually convert a value from one data type to another datatype, by specifying the destination data type within brackets, at left hand side of the source value
- Loosy conversion: If the destination type is not sufficient enough to store the converted value, teh value may loose.
- Child class to Parent class

## How?

```cs
// Syntax:
(DestinationDataType)SourceValue
```

## When?

- At all cases in the table of implicit casting
- At the case in the following table of explicit casting
- `sbyte` -> `byte`, `ushort`, `uint`, `ulong`
- `byte` -> `sbyte`
- `short` -> `sbyte`, `byte`, `ushort`, `uint`, `ulong`
- `ushort` -> `sbyte`, `byte`, `short`
- `int` -> `sbyte`, `byte`, `short`, `ushort`, `uint`, `ulong`
- `uint` -> `sbyte`, `byte`, `short`, `ushort`, `int`
- `long` -> `sbyte`, `byte`, `short`, `ushort`, `int`, `uint`, `ulong`
- `ulong` -> `sbyte`, `byte`, `short`, `ushort`, `int`, `uing`, `long`
- `float` -> `sbyte`, `byte`, `short`, `ushort`, `int`, `uint`, `long`,
- `double` -> `sbyte`, `byte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `decimal`
- `decimal` -> `sbyte`, `byte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`
- `char` -> `sbyte`, `byte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `decimal`
- `bool` -> [none]
- `string` -> [none]

```cs
int a = 100;
float b;

b = a; // Implicit Casting
b = (float)a; // Explicit Casting


int x = 500;
byte y = (byte)x; // 244
```
