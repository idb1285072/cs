# Field

## What?

- Variables that are declared in the class; stored in the objects
- Isolated for each object

## Syntax

```cs
AccessModifier Modifier type fieldName;
```

- AccessModifier
  - private
  - protected
  - private protected
  - internal
  - protected internal
  - public
- Modifier
  - static
    - static fields are common to all objects
    - accessible when class name
  - const
    - const field's value cannot be modified
    - compiler replaces all constant names with respective value
    - const is by default static
  - readonly
    - readonly field's value cannot be modified
    - compilation-time restriction only
- default AccessModifier is private
- Modifier is optional; so no default modifier

---

## 🎫 AccessModifier

- `private` (default): same class only
- `protected`: child
- `private protected`: child of same assembly
- `internal`: same assembly
- `protected internal`: same assembly and other assembly child
- `public`: anywhere

> Note: default access modifier of class is internal but default access modifier of property is private

---

static field:

- static fields are store outside the object (store in class's memory)
- static fields are common to all objects of a class

Instance Fields

- access by ClassName
  Static Fields
