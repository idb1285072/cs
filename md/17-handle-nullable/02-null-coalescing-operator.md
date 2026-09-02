# Null coalescing operator

## What?

- The null coalescing operator checks whether the value is null or not
  - It returns the left-hand-side operand if the value is not null
  - It returns the right-hand-side operand if the value is null

## Advantage

- Simplifying the syntax of if statement to check if the value is null

## Syntax

```cs
variableName ?? valueIfNull;
```

## Example

```cs
int? age;
// null check by if
if (age != null)
{
  age = 19;
}

// HasValue
if (age.HasValue)
{
  age = 19;
}

// Null-Coalescing Operator
age = age ?? 19;
```
