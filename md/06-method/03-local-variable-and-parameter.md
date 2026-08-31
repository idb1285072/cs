## Syntax

```cs
class ClassName
{
  returnType MethodName(DataType parameterName)
  {
    DataType variableName;
  }
}
```

- When call a method, new stack create for the method
- Local Variable and Parameter values are store in the stack
- When method execution at the last of the method, the stack delete with local variables and parameters

## Parameters

- The variables that are being received from the method caller are called as parameters
- The parameters are stored in the Stack of the method
- For every method call, a new stack will be created

## Local Variables

- The variables that are declared inside the method are called as Local Variables. Local Variables can be used only within the same method
- Local variables are stored in the same stack, just like parameters
- The stack will be deleted at the end of method execution. So all local variables and parameters will be deleted
