# Static Field

## What?

- Static fields are store outside the object (store Class Memory in heap)
- Static fields are **common to all objects** of class

## Example

```cs
class BankAccount
{
  long accountNumber;
  string accountHolderName;
  double currentBalance;
  static string bankName;
}
```

```cs
class Class
{
  int studentId;
  string studentName;
  static string roomNumber;
}
```

## Instance Fields vs Static Fields

- Instance Fields
  - Stored in Objects in heap
  - represent data related to object
  - declared without `static` keyword
  - accessible with object. (through reference variable)
  - allocated separately for each object, because instance fields are stored inside the objects

- Static Fields
  - Store in class's memory in heap
  - represents common data that belongs to all objects
  - declared with `static` keyword
  - accessible with class name only (not with object)
  - allocated only once for the entire program; i.e. when the class is used for the first time while executing the program
