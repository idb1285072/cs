# Method

## What?
- **group of statement**/**block of code** that **performs a specific task**
- can receive one or more input as **parameters** and can **return** a value
- parameters are optional
- must call the method to execute
- methods are class member

## Syntax

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

## Why?
- reuse code