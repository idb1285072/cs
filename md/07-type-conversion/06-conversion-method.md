# Conversion Methods

## What?

- Conversion method is a pre-defined method, which converts any primitive type (and also string) to any other primitive type (and also string)

## 💡

- The System.Convert is a class, which contains a set of pre-defined methods.
- It raises FormatException, if the source value is invalid
- For each data type, we have a conversion method.
- All conversion methods are static mehtods

## Syntax

```cs
type variable = Convert.ConversionMethod(SourceValue);
```

## Refs

- sbyte -> System.Convert.ToSByte(value)
- byte -> System.Convert.ToByte(value)
- short -> System.Convert.ToInt16(value)
- ushort -> System.Convert.ToUInt16(value)
- int -> System.Convert.ToInt32(value)
- uint -> System.Convert.ToUInt32(value)
- long -> System.Convert.ToInt64(value)
- ulong -> System.Convert.ToUInt64(value)
- float -> System.Convert.ToSingle(value)
- double -> System.Convert.ToDouble(value)
- decimal -> System.Convert.ToDecimal(value)
- char -> System.Convert.ToChar(value)
- string -> System.Convert.ToString(value)
- bool -> System.Convert.ToBoolean(value)
