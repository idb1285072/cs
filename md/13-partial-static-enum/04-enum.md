# Enumerations

## What?

- Enumeration is a collection of constants
- Enumeration is used to specify the list of options allowed to be stored in a field / variables.

## Goal

- Use enumeration if you don't want to allow other developer s to assign other value into a field / variable, other than the list of values specified in the enumeration

## Syntax

```cs
// declare
enum EnumerationName
{
  Constant1,
  Constant2,
  ...
}

// accessing
EnumerationName.ConstantName;
```

## Note

- By default, each constant will be assigned to a number, starts from zero; however you change the number (integer only).
- The default data type of enum member is int. However, you can change its data type as follows.
  ```cs
  enum EnumerationName: datatype
  {
    Constant1 = value,
    Constant2 = value,
    ...
  }
  ```
