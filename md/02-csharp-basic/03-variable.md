# Variable

## What?

- Variable is a **named memory location** in RAM
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

- should not contain space
- should not contain special characters (except underscore)
- duplicate variable names are not allowed
- cannot be keywords
- should use camelCase
