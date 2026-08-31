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

# Auto Implemented Property Initializer

## Example

```cs
public string Name {get; set;} = "Default Value";
```
