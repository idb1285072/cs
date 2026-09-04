# Delegate

## What?

- Delegate Type is a type that represents methods that have specific parameters and return type
- The delegate (a.k.a. delegate object), is an object that stores reference (address) of a specific method of a specific class, with compatible parameters and return type, which is already defined in the delegate type.

## Syntax

```cs
public delegate ReturnType DelegateTypeName(param1, param2, ...);

DelegateTypeName ReferenceVariable = MethodName;

ReferenceVariable.Invoke(arg1, arg2, ...);
```

## Rule

- You can invoke the methods using delegate objects or delegates
- Delegates are used to pass methods as arguments to other methods
- The method signature (parameters and return type) must match between the method and delegate
- Delegates can be used as parameter type or return type of a method
- You can store references of non-static method or static method in the delegate object
- The methods, which reference is stored in the single-cast delegate object can have return value
- The methods, which reference is stored in the multi-cast delegate object, cannot have return value; in case, if they have return value, the return value lastly-executed method only can be received; others will be ignored.
- All delegate types are derived from `System.Delegate` class
