# Interface

## What?

- Interface is a **set of abstract methods**, that **must be implemented** by the child classes

## How?

```cs
interface InterfaceName
{
  ReturnDataType MethodName(param1, ...);
}

class ChildClassName: InterfaceName
{
  public ReturnDataType MethodName(param1,...)
  {

  }
}
```

## Rules

- The child class that implements the interface, must implement all methods of the interface
- Interface methods are by default public and abstract
- You cannot create object for interface
- You can create reference variable for the interface
- The reference variable of interface type can only store the address of objects of any one of the corresponding child classes
- You can implement multiple interfaces in the same child class [Multiple Inheritance]
- An interface can be child of another interface

## Example

```cs
public interface IEmployee
{
  // abstract methods
  string GetHealthInsuranceAmount();

  // auto-properties
  int EmployeeId {get; set;}
  string EmployeeName {get; set;}
  string Location {get; set;}
}
```
