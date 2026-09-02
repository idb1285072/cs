# Explicit Interface Implementation

## What?

- Explicit interface implementation is used to implement an interface method privately; that means the interface method becomes as private member to the child class.

## Example

```cs
interface IVehicle
{
  void Move();
}
interface IFlyingMachine
{
  void Move();
}
class FlyingVehicle: IVehicle, IFlyingMachine
{
  void IVehicle.Move(){}
  void IFlyingMachine.Move(){}
}

IVehicle c1 = new FlyingVehicle();
```

## Rules

- If a child class inherits from two or more interfaces, and there is a duplicate method (having same name and parameters) among those interfaces; then use Explicit interface implementation, to provide different implementations for different interface methods respectively
- You can use explicit interface implementation to create private implementation of interface method; so that you can create abstraction for those methods.
- Must call the method by interface type reference variable (not by the child class type reference variable because by default in child class the method is private and you cannot change it)
