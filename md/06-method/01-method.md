# Method

- group of statement/block of code that performs a specific task
- can receive one or more input as **parameters** and can **return** a value
- parameters are optional
- must call the method to execute
- methods are class member
- inside class

### Syntax

```cs
AccessModifier Modifier ReturnType MethodName(parameters){
  MethodBody
}
```

- AccessModifier
  - `private` (default): same class only
  - `protected`: child
  - `private protected`: child of same assembly
  - `internal`: same assembly
  - `protected internal`: same assembly and other assembly child
  - `public`: anywhere
- Modifier
  - `static`
  - `virtual`
  - `abstract`
  - `override`
  - `new`
  - `partial`
  - `sealed`
- no default modifier. modifier is optional.
- default AccessModifier is private
- No Return value `void`

---

### Parameters

- The variables that are being received from the method caller are called as parameters
- The parameters are stored in the stakc of the method
- For every method call, a new stack will be created

### Local Variable

- The variables that are declared inside the method are called as Local Variables.
- Local variables can be used only within the same method
- Local variables are stored in the same stack, just like parameters.
- The stack will be deleted at the end of method execution. So all the local variables and paramters will be deleted
