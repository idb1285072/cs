## What?

- Lambda Expressions (a.k.a. Statement Lambda) are name-less methods, that can be invoked by using the delegate variable or an event, much like anonymous methods.

## How?

```cs
EventName += (param1, param2, ...) =>
{
  // method body here
}
```

## Rule

- Lambda Expressions can be used anywhere within the method, to create methods instantly, without define a method at the class level
- Advantage: It provides more easier and convenient syntax than Anonymous methods
- `=>` operator is called as `goes to` or `goes into` operator
