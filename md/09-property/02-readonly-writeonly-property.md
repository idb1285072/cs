# Readonly Property

- contains only get accessor
- reads and returns the value of field; but not modifies the value of the field
- ```cs
  AccessModifier DataType PropertyName
  {
    get {return field;}
  }
  ```

# Write-only Property

- Contains only set accessor
- Validates and assign incoming value into the field; but return the value.
- ```cs
  AccessModifier DataType PropertyName
  {
    set {field: value;}
  }
  ```
