# Indexer

## What?

- Indexer is a special member of class, which contains set-accessor and get-accessor to access a group of items / elements

## Goal

- Receive a number / string. Search for the particular item among a group of items; set or get value into the group of items
- It provides shorter syntax to access a group of items

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

## Example

```cs
class Indexer
{
  static void Main()
  {
    Car car = new Car();
    car[0] = "BMW";
    System.Console.WriteLine(car[0]); // Output: BMW
    System.Console.ReadKey();
  }
}


public class Car
{
    // private field to hold the brands array
  private string[] _brands = new string[] { "Toyota", "Honda", "Ford", "Chevrolet", "Nissan" };

  // public indexer to access the brands array
  public string this[int index]
  {
    get
    {
      if (index >= 0 && index < _brands.Length)
      {
          return _brands[index];
      }
      else
      {
          throw new System.IndexOutOfRangeException("Index is out of range.");
      }
    }
    set
    {
      if (index >= 0 && index < _brands.Length)
      {
          _brands[index] = value;
      }
      else
      {
          throw new System.IndexOutOfRangeException("Index is out of range.");
      }
    }
  }
}
```

## 💡

- Indexers are always created with `this` keyword
- Indexers are generally used to access group of elements
- Parameterized properties are called indexer
- Indexers are implemented through get and set accessors along with the [] operator
- Indexer must have one or more parameters
- ref and out parameter modifiers are not permitted in indexer.
- Indexer cannot be static
- Indexer is identified by its signature (syntax of calling where as a property is identified it's name)
- Indexer can be overloaded

# Indexer Overloading

## Example

```cs
class Indexer
{
  static void Main()
  {
    Car car = new Car();
    car[0] = "BMW";
    System.Console.WriteLine(car[0]); // Output: BMW

    car["first"] = "Mercedes";
    System.Console.WriteLine(car["first"]); // Output: Mercedes

    System.Console.ReadKey();
  }
}

public class Car
{
  // private field to hold the brands array
  private string[] _brands = new string[] { "Toyota", "Honda", "Ford", "Chevrolet", "Nissan" };
  private string[] _names = new string[] {"first", "second", "third", "fourth", "fifth"};

  // public indexer to access the brands array
  public string this[int index]
  {
    get
    {
      return _brands[index];
    }
    set
    {
      _brands[index] = value;
    }
  }

  // indexer overloading
  public string this[string name]
  {
    get
    {
      return _brands[System.Array.IndexOf(_names, name)];
    }
    set
    {
      _brands[System.Array.IndexOf(_names, name)] = value;
    }
  }
}
```
