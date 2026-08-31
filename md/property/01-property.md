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

# Summary

- use property in real-time projects is recommended
- occupy no memory
- protection layer surrounding the private field
