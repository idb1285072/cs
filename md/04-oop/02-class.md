# Implementation Class in C#

```cs
AccessModifier Modifier class ClassName
{
  Fields
  Methods
  Constructors
  Properties
  Events
  Destructors
}
```

- AccessModifier
  - **internal**: accessible within the same assembly
  - **public**: accessible in the same assembly and also in other assemblies.
  - default access modifier for class is internal
- Modifier
  - **static**: static class contains only static members
  - **abstract**: abstract class can additionally contain abstract methods
  - **sealed**: sealed class cannot be inherited
  - **partial**: multiple partial classes that have same name, are combined into single class
  - Modifier is optional for class. No default Modifier
- Member
  - Fields
  - Methods
  - Constructors
  - Properties
  - Events
  - Destructors

> The compiled source code of a project is called as Assembly

> Project is the collection of file

> Solution is the collection of Projects

# Implementation Object
- Stack (Object reference) and Heap (Object value)
- Create Reference Variable
  - `ClassName referenceVariable;`
  - Classes are type
- Create Object and store its reference into the reference variable
  - `new ClassName();`