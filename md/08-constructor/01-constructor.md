# Constructor

## What?

- **Special Method** of class, which contains initialization logic of fields.
- **call automatically when creating object** of a class
- initializes the fields and also contains the additional initialization logic (if any)

## Syntax

```cs
AccessModifier Modifier ClassName(Parameters)
{
  // Initialize fields
}
```

- AccessModifiers
  - `private`
  - `protected`
  - `private protected`
  - `internal`
  - `protected internal`
  - `public`
- Modifier
  - `static`

## Example

```cs
class Car
{
  string carBrand;
  string carModel;
  int carYear;

  public Car(string carBrand, string carModel, int carYear)
  {
    this.carBrand = carBrand;
    this.carModel = carModel;
    this.carYear = carYear;
  }
}
```

## 💡 Rules

- Constructor's name should be same as class name
- Constructor is recommended to be public member or internal member; If it is a private member it can be called within the same class only; so you can create object of a class only inside the same class; but not outside the class.
- Constructor can have one or more parameters
- Constructor cannot return any value; so no return type
- A class can have one or more constructors; but all the constructors of the class must have different types of parameters
