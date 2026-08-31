# Property

- Property is a collection of two accessors (get-accessor and set-accessor)

## Goal

- Recieve the incoming value; validate the value; assign value into field
- security layer surrounding fields/ garde of fields

## 💡

- No memory will be allocaed for the property

## Syntax

```cs
AccessModifier Modifier DataType PropertyName
{
  set { field = value }
  get { return field }
}
```

- AccessModifier
  - `private`
  - `protected`
  - `private protected`
  - `internal`
  - `protected internal`
  - `public`
- Modifier
  - `static`
  - `virtual`
  - `abstract`
  - `override`
  - `new`
  - `sealed`

## Example

```cs
class Car
{
  private string _carBrand;
  public string CarBrand
  {
    set
    {
      this._carBrand = value;
    }
    get
    {
      return this._carBrand;
    }
  }
}
```

# Readonly Property

- contains only get accessor
- reads and returns the value of field; but not modifies the value of the field

# Writeonly Property

- Contains only set accessor
- Validates and assign incoming value into the field; but return the value.

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

# Summary

- use property in real-time projects is recommended
- occupy no memory
- protection layer surrounding the private field
