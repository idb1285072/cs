## What?

- Anonymous methods are name-less methods, that can be invoked by using the delegate variable or an event

## When?

- Anonymous methods can be used anywhere within the method, to create methods instantly, without define a method at the class level.
- Advantage: We need not create a named method (normal method) to quickly handle an event

## Rule

- It cannot be called without a delegate or event
- It cannot contain jump statements like goto, break, continue
- It can access local variables and parameters of outer method
- It can be passed as a parameter to any method; in this case, the delegate acts as delegate acts as data type for the anonymous method
- It cannot access ref or out parameter of an outer method
- It is mainly used for event handles
