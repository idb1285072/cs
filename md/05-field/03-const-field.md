# Constant Field

## What?

- Constant Fields are like static fields, that are common to all objects of the class
- We can't change the value of constant field

## Rule

- Constant Fields are accessible with class name [not with object]
- Constant Fields are not stored in the object; will not be stored anywhere.
- Constant Fields will be replaced with its value, while compilation; so it will not be stored anywhere in memory
- Constant Fields will be replaced with its value, while compilation; so it will not be stored anywhere in memory
- Constant Fields must be initialized, in line with declaration (with a literal value only)
- Constant can also be declared as local constants (in a method)

## Syntax

```cs
AccessModifier const type FieldName = value;
```
