### Questions

**1. What is the main purpose of a constructor in C#?**
A) Destroy an object
B) Initialize an object
C) Compile a class
D) Inherit a class

**2. What must be the same as the class name?**
A) Method
B) Property
C) Constructor
D) Variable

**3. What does a constructor have as its return type?**
A) `void`
B) `int`
C) `object`
D) No return type

**4. When is an instance constructor normally called?**
A) When the class is compiled
B) When an object is created
C) When the program ends
D) When a method is overridden

**5. Which keyword is commonly used to create an object and invoke its constructor?**
A) `this`
B) `base`
C) `new`
D) `static`

**6. Which is a valid parameterless constructor?**
A) `public void Student() { }`
B) `public Student() { }`
C) `public int Student() { }`
D) `Student void() { }`

**7. What is a parameterized constructor?**
A) A constructor with no parameters
B) A constructor with one or more parameters
C) A static method
D) A destructor

**8. If no instance constructor is explicitly defined in a class, what does the compiler generally provide?**
A) A parameterized constructor
B) A static constructor
C) A parameterless constructor
D) A private constructor

**9. What happens if you define a parameterized constructor but no parameterless constructor?**
A) C# automatically creates a parameterless constructor
B) The class cannot have objects
C) The compiler does not automatically add a parameterless constructor
D) The parameterized constructor becomes static

**10. Which statement correctly describes an implicit constructor?**
A) It is always written by the programmer
B) It is supplied by the compiler when applicable
C) It must have parameters
D) It must be static

**11. What is an explicit constructor?**
A) A constructor written by the programmer
B) A constructor created by the CLR only
C) A destructor
D) An inherited constructor

**12. What is constructor overloading?**
A) Overriding a constructor
B) Having multiple constructors with different parameter lists
C) Calling a constructor twice
D) Making a constructor static

**13. Which is required for constructor overloading?**
A) Different class names
B) Different return types
C) Different parameter lists
D) Different access modifiers only

**14. Can constructors be overloaded?**
A) Yes
B) No
C) Only static constructors
D) Only private constructors

**15. Which pair demonstrates valid constructor overloading?**

```csharp
class Student
{
    Student() { }
    Student(string name) { }
}
```

A) Yes
B) No
C) Only if both are static
D) Only if both return `void`

**16. Can constructors have access modifiers such as `public` and `private`?**
A) Yes
B) No
C) Only `public`
D) Only `private`

**17. What is a static constructor mainly used for?**
A) Initializing static data
B) Creating multiple objects
C) Destroying objects
D) Overriding methods

**18. Which keyword identifies a static constructor?**
A) `static`
B) `shared`
C) `class`
D) `const`

**19. Which is a valid static constructor?**

```csharp
class Test
{
    static Test()
    {
    }
}
```

A) Yes
B) No
C) Only with `public`
D) Only with parameters

**20. Can a static constructor have parameters?**
A) Yes
B) No
C) Only one parameter
D) Only optional parameters

**21. Can a static constructor have an access modifier such as `public`?**
A) Yes
B) No
C) Only `private`
D) Only `protected`

**22. How many times does a static constructor run for a given type?**
A) Every time an object is created
B) Twice
C) Once
D) Never

**23. What kind of members can a static constructor directly access?**
A) Only instance members
B) Static members
C) Local variables from another method
D) Private instance fields only

**24. Can a static constructor be overloaded?**
A) Yes
B) No
C) Only with different parameters
D) Only with different return types

**25. What is an object initializer used for?**
A) Destroying an object
B) Initializing fields/properties when creating an object
C) Creating a class
D) Overriding a constructor

**26. Which is a valid object initializer?**

```csharp
Student s = new Student
{
    Name = "Rahim",
    Age = 20
};
```

A) Yes
B) No
C) Only for static classes
D) Only for interfaces

**27. What does this code do?**

```csharp
Student s = new Student
{
    Name = "Rahim",
    Age = 20
};
```

A) Only creates the class
B) Creates an object and initializes its members
C) Creates a static object
D) Calls a destructor

**28. In an object initializer, which members can normally be assigned?**
A) Accessible fields/properties that can be assigned
B) Only private fields
C) Only methods
D) Only static constructors

**29. What happens first in this code?**

```csharp
Student s = new Student()
{
    Name = "Rahim"
};
```

A) `Name` is assigned first, then constructor runs
B) Constructor runs first, then `Name` is assigned
C) Nothing happens
D) Destructor runs first

**30. Which statement is TRUE about an object initializer?**
A) It replaces the constructor completely
B) It prevents the constructor from running
C) The constructor runs first, followed by member initialization
D) It can only be used with static constructors

---

## Answer Key

| #  | Answer | #  | Answer | #  | Answer |
| -- | ------ | -- | ------ | -- | ------ |
| 1  | **B**  | 11 | **A**  | 21 | **B**  |
| 2  | **C**  | 12 | **B**  | 22 | **C**  |
| 3  | **D**  | 13 | **C**  | 23 | **B**  |
| 4  | **B**  | 14 | **A**  | 24 | **B**  |
| 5  | **C**  | 15 | **A**  | 25 | **B**  |
| 6  | **B**  | 16 | **A**  | 26 | **A**  |
| 7  | **B**  | 17 | **A**  | 27 | **B**  |
| 8  | **C**  | 18 | **A**  | 28 | **A**  |
| 9  | **C**  | 19 | **A**  | 29 | **B**  |
| 10 | **B**  | 20 | **B**  | 30 | **C**  |

### Quick Revision

* **Constructor** → Initializes an object.
* **Parameterless constructor** → No parameters.
* **Parameterized constructor** → Takes parameters.
* **Implicit constructor** → Supplied by compiler when applicable.
* **Explicit constructor** → Written by programmer.
* **Constructor overloading** → Multiple constructors with different parameter lists.
* **Static constructor** → Initializes static data; runs once per type.
* **Object initializer** → Creates an object and initializes its fields/properties using `{ }`.
