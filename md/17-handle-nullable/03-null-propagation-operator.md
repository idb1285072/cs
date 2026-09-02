## What?

- The Null Propagation Operator (`?.`) and (`?[]`) checks the value of left-hand operand whether it is null or not
  - It returns the right-hand-side operand (property or method), it the value is not null
  - It returns null, if the value is null
- It accesses the property or method, only if the reference variable is not null; just returns null, if the reference variable is null

## Syntax

```cs
referenceVariable?.fieldName;

// same as
(referenceVariable==null)?null:referenceVariable.fieldName;
```

## Advantage

- We can invoke desired member (property or method) after checking if null.
