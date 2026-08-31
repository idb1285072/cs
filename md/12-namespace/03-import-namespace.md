# Import Namespace by `using` directive

## What?

- use `using` keyword to access namespace members **without full namespace name** every time

## Why?

- Easy to access namespace member (short-cut way)

## How?

```cs
// instead of
Compay.HR.Employee emp = new Company.HR.Employee();
System.Console.WriteLine(emp.Name);

// we can use
using Company.HR;
using System;

Employee emp = new Employee();
Console.WriteLine(emp.Name);
```

## Rules

- When you import a namespace, you can directly access namespace member only. **not the inner namespace member**.
- One `using` directive can import one namespace only
- The `using` directive statement (**top-level statement**) should be placed at the top of the file.
