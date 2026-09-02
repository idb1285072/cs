## Rule

- Value Types (structures, enumerations) are by default non-nullable types
- Reference Types (classes, interfaces) are by default nullable types
- Converting value type to nullable type use: `Nullable<int> x = 10;` or `int? x = 10`
- `x != null` and `x.HasValue` are same
