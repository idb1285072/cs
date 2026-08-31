# Parameter-less Constructor vs Parameterized Constructor

- Parameter-less Constructor
  - Constructor without parameters
  - It generally initializes fields with some literal values or contains some general-initialization logic of object

- Parameterized Constructor
  - Constructor with one or more parameters
  - It generally initializes fields by assigning values of parameters into fields

# Implicit vs Explicit Constructor

- Implicit:
  - If there is a **class without constructor**, then the constructor automatically provides an empty constructor, while compilation, which initializes nothing. It is called as **Implicit constructor** or **Default constructor**.
  - It is just to satisfy the rule **Class should have a constructor**
- Explicit:
  - The constructor (parameter-less or parameterized) while is created by the developer is called as Explicit constructor.
  - In this case, the C# compiler doesn't provide any implicit constructor
