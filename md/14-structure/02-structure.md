# Structure

## What?

- Structure is a type, similar to class, which can contain fields, methods, parameterized constructors, properties and event

## Syntax

```cs
struct StructureName
{
  fields
  methods
  parameterized constructor
  properties
  events
}
```

## Example

```cs
struct Student
{
  public int id;
  public string name;
  public string GetStudentName()
  {
    return studentName;
  }
}
```
## Rule
- The instance of structure is called as structure instance of structure variable; but not called as object
  - We cannot create object for structure
  - Objects can be created only based on class
- Structure instances are stored in stack
- Structure doesn't support user-defined parameter-less constructor and also destructor
- Structure cannot inherit from other classes or structures
- Structure can implement one or more interfaces
- Structure doesn't support virtual and abstract methods
- Structures are mainly meant for storing small amount of data (one or very few values)
- Structures are faster than classes, as its instances are stored in stack

## Structure vs Class
| Structure | Class |
| --- | --- | 
| value types | reference types |
| Structure instances (includes fields) are store in stack. Structures doesn't require Heap | Class instances (objects) are stored in Heap. Class reference variables are stored in stack |
| Suitable to store small data (only one or two values) | Suitable to store large data (any number of value) |
| Memory allocation and de-allocation is faster, in case of one or two values | Memory allocation and de-allocation is a bit slower |
| Structures doesn't support parameter-less constructor | support |
| doesn't support inheritance (cannot be parent or child) | Classes support inheritance | 
| The new keyword just initializes all fields of the structure instance | The new keyword creates a new object | 
| Structures doesn't support abstract methods and virtual methods | support |
| doesn't support destructors | support |
| Structures are internally derived from `System.ValueType` | Classes are internally and directly derived from `System.Object`. |
| doesn't support to initialize non-static fields, in declaration |support to initialize non-static fields, in declaration|
| doesn't support protected and protected internal access modifier | support |
doesn't support to assign null | Class's reference variables supports to assign null | 
