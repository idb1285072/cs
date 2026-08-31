# Parameter-less Constructor vs Parameterized Constructor

- Parameter-less Constructor
  - Constructor **without parameters**
  - It generally initializes fields with some literal values or contains some general-initialization logic of object

- Parameterized Constructor
  - Constructor **with one or more parameters**
  - It generally initializes fields by assigning values of parameters into fields

| **Parameterless Constructor**    | **Parameterized Constructor**                    |
| -------------------------------- | ------------------------------------------------ |
| Has **no parameters**            | Has **one or more parameters**                   |
| Gives default/initial values     | Gives **specific values** during object creation |
| Called without passing arguments | Called by passing arguments                      |
| Example: `new Student()`         | Example: `new Student("Rahim", 20)`              |

### Main difference:

> - 👉 Parameterless constructor = no parameters
> - 👉 Parameterized constructor = accepts parameters for initialization

# Implicit vs Explicit Constructor

- Implicit:
  - If there is a **class without constructor**, then the constructor automatically provides an empty constructor, while compilation, which initializes nothing. It is called as **Implicit constructor** or **Default constructor**.
  - It is just to satisfy the rule **Class should have a constructor**
- Explicit:
  - The constructor (parameter-less or parameterized) while is created by the developer is called as Explicit constructor.
  - In this case, the C# compiler doesn't provide any implicit constructor

| **Implicit Constructor**                                   | **Explicit Constructor**                           |
| ---------------------------------------------------------- | -------------------------------------------------- |
| Provided **automatically by the compiler**                 | **Written manually by the programmer**             |
| Created when you **don't define any instance constructor** | Created when you **define a constructor yourself** |
| Usually a **parameterless constructor**                    | Can be parameterless or parameterized              |
| Initializes fields with their **default values**           | Can initialize fields with **custom values/logic** |
| No constructor code is written by you                      | Constructor code is written by you                 |

### Main difference:

> - 👉 Implicit = Compiler creates it
> - 👉 Explicit = Programmer writes it
