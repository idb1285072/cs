
# Object Initializer

## What?

- Special syntax to initialize fields/properties of class, along with creating the object.

## Why?
- Makes code shorter and cleaner.

## 💡 Rules

- Execute after the constructor
- It is only for initialization of fields/properties, after creating object; it cannot have any initialization logic. It **does not replace a constructor**.
- You can use it with parameterless or parameterized constructors.

## Syntax

```cs
new ClassName(){field1: value, field2: value}
```

## Example
```cs
// without object initializer
Student s = new Student();
s.Name = "Rahim";
s.Age = 20;

// with object initializer
Student s = new Student
{
    Name = "Rahim",
    Age = 20
};
```