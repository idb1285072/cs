# Auto Implemented Property

## What?

- Property with no definition for set-accessor and get-accessor
- Used to create property easily (with shorter syntax)
- Creates a private field (with name as \_propertyName) automatically, while compilation time.
- Auto-Implemented property can be read-only (only get accessor) property; but it cannot write-only (only set accessor)

## Syntax

```cs
AccessModifier Modifier PropertyName
{
  get;
  set;
}
```

## Example

```cs
public int Id {get; set;}

// Compiler Create
private int _id;
public int Id
{
  set
  {
    _id = value;
  }
  get
  {
    return _id;
  }
}
```

# Auto Implemented Property Initializer

## What?

- New feature in C# 6.0
- You can initialize value into auto-implemented property

## Example

```cs
public string Name {get; set;} = "Default Value";
```
