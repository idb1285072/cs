# Constructor

## What?

- A constructor is a **special method** that **runs automatically when an object is created**.
- initializes the fields and also contains the additional initialization logic (if any)

## Why?

- **Main purpose**: Initialize the object.

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

- **Special method** used to **initialize an object**.
- It is called **automatically** when an object is created using `new`.
- It is mainly used to **initialize fields/properties**.
- Constructor name **must be the same as the class name**.
- It has **no return type**, not even `void`.
- Constructors can have **parameters or no parameters**.
- A class can have one or more constructors; but all the constructors of the class must have different types of parameters
- Constructor is recommended to be `public` member or internal member; If it is a private member it can be called within the same class only; so you can create object of a class only inside the same class; but not outside the class.
- Constructors can be private, which is useful for patterns such as Singleton or controlling object creation.
- If you don't write any constructor, C# provides a **default parameterless constructor** (subject to certain class/constructor rules).
