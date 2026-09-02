## When?

- Use readonly structures in case of all of these below:
  - All fields are readonly
  - All properties have only get accessors (readonly properties)
  - There is a parameterized constructor that initializes all the fields
  - You don't want to allow to change any field or property of the structure
  - Methods can read fields; but cannot modify

## Rule

- readonly structures is a new feature in C# 8.0
- This feature improves the performance of structures
