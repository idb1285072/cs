# Nested Namespace

## What?
- a namespace declared inside another namespace.

## Why?
- organize code into further sub-groups.

## How?
```cs
// create nested namespace
namespace Company
{
  namespace HR
  {
    class Employee
    {

    }
  }
}
//or, shorter syntax
namespace Company.HR
{
  class Employee
  {

  }
}

// access members
Company.HR.Employee emp = new Company.HR.Employee();
```