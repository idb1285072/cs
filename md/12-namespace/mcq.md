**1. What is the main purpose of a namespace in C#?**
A. To execute code
B. To organize types and avoid naming conflicts
C. To create objects
D. To allocate memory

**2. Which keyword is used to declare a namespace?**
A. `package`
B. `module`
C. `namespace`
D. `group`

**3. Which is a valid namespace declaration?**
A. `namespace MyApp { }`
B. `namespace = MyApp { }`
C. `namespace(MyApp) { }`
D. `namespace: MyApp { }`

**4. Which type can be declared inside a namespace?**
A. Class
B. Interface
C. Struct
D. All of the above

**5. Can two namespaces contain classes with the same name?**
A. No, never
B. Yes
C. Only if classes are private
D. Only in different projects

**6. What is a nested namespace?**
A. A namespace inside another namespace
B. A class inside a namespace
C. A namespace inside a method
D. A namespace with no classes

**7. Which represents a nested namespace?**
A. `namespace A.B { }`
B. `class A.B { }`
C. `using A.B;`
D. `namespace A + B { }`

**8. In `namespace Company.Project.Models`, what is `Models`?**
A. Class
B. Method
C. Nested namespace
D. Object

**9. Which is equivalent to a nested namespace declaration?**

```csharp
namespace A
{
    namespace B
    {
    }
}
```

A. `namespace A.B { }`
B. `namespace A+B { }`
C. `namespace A/B { }`
D. `namespace B.A { }`

**10. What keyword is generally used to import a namespace?**
A. `include`
B. `import`
C. `using`
D. `require`

**11. Which statement imports `System.Collections.Generic`?**
A. `import System.Collections.Generic;`
B. `using System.Collections.Generic;`
C. `include System.Collections.Generic;`
D. `use System.Collections.Generic;`

**12. Why do we use `using System;`?**
A. To create the `System` namespace
B. To access types in `System` without fully qualifying them
C. To delete the `System` namespace
D. To inherit from `System`

**13. Without `using System;`, which can be used to call `WriteLine`?**
A. `Console.WriteLine()`
B. `System.Console.WriteLine()`
C. `WriteLine.System()`
D. `using.Console.WriteLine()`

**14. Does `using` copy the namespace's code into your program?**
A. Yes
B. No
C. Only classes are copied
D. Only methods are copied

**15. What is the purpose of a `using` alias?**
A. To rename a namespace/type for use in the current file
B. To create a new namespace
C. To delete a namespace
D. To inherit a namespace

**16. Which is the correct syntax for a namespace alias?**
A. `alias M = MyApp.Models;`
B. `using M = MyApp.Models;`
C. `using alias M MyApp.Models;`
D. `namespace M = MyApp.Models;`

**17. Given:**

```csharp
using M = MyApp.Models;
```

What is `M`?
A. Class
B. Method
C. Alias
D. Object

**18. Given:**

```csharp
using M = MyApp.Models;

M.Student s;
```

What does `M` represent?
A. `Student`
B. `MyApp`
C. `MyApp.Models`
D. `s`

**19. Why are aliases particularly useful?**
A. For resolving naming conflicts
B. For increasing memory
C. For creating threads
D. For executing methods automatically

**20. Which alias can resolve a conflict between two namespaces containing `Student`?**
A. `using A = School1.Models;`
B. `using Student = School1;`
C. `alias Student;`
D. `namespace Student;`

**21. What does `using static` allow you to do?**
A. Import instance members
B. Access static members without the type name
C. Create static classes
D. Convert a class into a namespace

**22. Which is valid?**
A. `using static System.Math;`
B. `using System.Math.static;`
C. `static using System.Math;`
D. `import static System.Math;`

**23. Given:**

```csharp
using static System.Math;
```

Which can be written directly?
A. `Math.Sqrt(25)` only
B. `Sqrt(25)`
C. `System.Sqrt(25)`
D. `static.Sqrt(25)`

**24. Without `using static System.Math;`, which is correct?**
A. `Sqrt(25)`
B. `Math.Sqrt(25)`
C. `static Sqrt(25)`
D. `System.Sqrt(25)`

**25. What type of members are primarily made available by `using static`?**
A. Instance members
B. Static members
C. Private fields only
D. Constructors only

**26. Given:**

```csharp
using static System.Console;

WriteLine("Hello");
```

What is the effect?
A. `WriteLine` can be called without `Console.`
B. `Console` is renamed to `WriteLine`
C. A new console is created
D. The code will always produce an error

**27. Which statement is TRUE about `using static`?**
A. It imports an entire namespace
B. It allows direct access to static members of a type
C. It creates a nested namespace
D. It creates an alias automatically

**28. Which statement correctly combines an alias and a namespace?**
A. `using Models = MyApp.Models;`
B. `alias Models = MyApp.Models;`
C. `using namespace Models = MyApp.Models;`
D. `namespace Models = MyApp.Models;`

**29. Which statement correctly describes the difference between `using` and `using static`?**
A. `using` imports namespace names; `using static` makes static members directly accessible
B. They are exactly the same
C. `using` is only for classes; `using static` is only for namespaces
D. `using static` creates nested namespaces

**30. What is the best summary of namespaces and `using` directives?**
A. Namespaces organize code; `using` simplifies access to namespaces/types; aliases provide alternate names; `using static` simplifies access to static members
B. All of them create objects
C. All of them are used only for inheritance
D. They are all different ways to declare classes

### Answer Key

| Q  | Ans   | Q  | Ans   | Q  | Ans   |
| -- | ----- | -- | ----- | -- | ----- |
| 1  | **B** | 11 | **B** | 21 | **B** |
| 2  | **C** | 12 | **B** | 22 | **A** |
| 3  | **A** | 13 | **B** | 23 | **B** |
| 4  | **D** | 14 | **B** | 24 | **B** |
| 5  | **B** | 15 | **A** | 25 | **B** |
| 6  | **A** | 16 | **B** | 26 | **A** |
| 7  | **A** | 17 | **C** | 27 | **B** |
| 8  | **C** | 18 | **C** | 28 | **A** |
| 9  | **A** | 19 | **A** | 29 | **A** |
| 10 | **C** | 20 | **A** | 30 | **A** |
