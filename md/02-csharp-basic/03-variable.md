# Variable

## What?

- A variable is a **named storage location in memory** used to hold a value that can change during program execution.
- Variable is like a **container** to store value

## Rules

- All variables will be stored in stack
- For every method call, a new Stack will be created
- The variable's value can be changed any number of times
- The variables must be declared before its usages
- The variables must be initialized before reading its value
- Variable's datatype should be specified while declaring the variable; it can't be changed later.
- The stack (along with its variables) will be deleted automatically, at the end of method execution

## How?

```cs
// Declaration
DataType VariableName;
// initialization
VariableName = value;


// Declaration with initialization
DataType VariableName = value;

// Access
VariableName
```

## Variable Naming Rules
- can contain letters, digits, and `_` only. space or special character cannot contain.
- cannot start with digits.
- cannot be reserved keywords. But `@int` is ok.
- case-sensitive
- duplicate variable names are not allowed within the same scope
---
- should use camelCase
- use meaningful names. avoid vague names (`int x;`) or unnecessary abbreviations (`string cstName;`)
- Boolean variables should sound like a question/state - `isActive, isCompleted, hasPermission, canEdit`
