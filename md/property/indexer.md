## Syntax

```cs
AccessModifier Modifier DataType this[parameter]
{
  set {field = value;}
  get { return field;}
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
  - `virtual`
  - `abstract`
  - `override`
  - `new`
  - `sealed`

## 💡

- Indexers are always created with this keyword
- Indexers are generally used to access group of elements
- Parameterized properties are called indexer
- Indexers are implemented through get and set accessors along wiht the [] oprator
- Indexer must have one or more parameters
- ref and out parameter modifiers are not permitted in indexer.
- Indexer cannot be static
- Indexer is identified by its signature (syntax of calling where as a property is identified it's name)
- Indexer can be overloaded


# Indexer Overloading
