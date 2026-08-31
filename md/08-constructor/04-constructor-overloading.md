# Constructor Overloading

## What?

- multiple constructors with same name in the class, with different set of parameters (just like method overloading)

## Why?

- It provides flexibility when creating objects.

## 💡 Rules

- **Multiple constructors** can exist in one class.
- They must have **different parameter** lists.
- Difference can be in **number or type of parameters**.
- Return type is not used to overload constructors.
- It is recommended to write a parameter-less constructor in the class, in case of constructor overloading

## Example

```cs
class Student
{
    public string name;
    public int age;

    // Constructor 1
    public Student()
    {
        name = "Unknown";
        age = 0;
    }

    // Constructor 2
    public Student(string n)
    {
        name = n;
    }

    // Constructor 3
    public Student(string n, int a)
    {
        name = n;
        age = a;
    }
}

Student s1 = new Student();
Student s2 = new Student("Rahim");
Student s3 = new Student("Karim", 20);
```
