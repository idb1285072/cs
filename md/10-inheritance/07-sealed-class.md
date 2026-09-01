# Sealed Class

## What?

- Sealed class is a class, which is instantiable; but not inheritable
- Use sealed class, whenever you don't want to let other developers to create child classes for the specific class

## Syntax

```cs
sealed class Class1
{

}

class Class2: Class1 // error
{

}
```

## Rules

- Cannot contain `virtual` method
