# Property

- Property is a collection of two accessors (get-accessor and set-accessor)

## Goal

- Receive the incoming value; validate the value; assign value into field
- security layer surrounding fields/ garde of fields

## 💡

- No memory will be allocated for the property
- Access modifier is applicable for the property, set accessor and get accessor individually.
  - BUt access modifiers of accessors must be more restrictive than access modifier of property
  - Note: You can set access modifiers on either of set accessor or get accessor; not both at once.
  ```cs
  internal Modifier DataType PropertyName
  {
    private set {property = value}
    get {return property}
  }
  ```

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

## Set Accessor

- `set{ field: value; }`
- Used to validate the incoming value and assign the same into field
- Executes automatically when some value is assigned into the property
- Has default (implicit) parameter called `value`, which represents current value i.e. assigned to property
- Cannot have any additional parameters.
- Cannot return any value

## Get Accessor

- `get{ return field; }`
- Used to calculate value and return the same (or) when the value of field as-it-is
- Executes automatically when the property is retrieved.
- Has no implicit parameters
- Cannot have parameters
- Should return value of field
