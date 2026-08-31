# Static Constructor

- Instance Constructor
  - Initializes instance fields; but also can access static fields
  - Executes automatically every time when a new object is created for the class
  - private by default. We cannot use any of access modifiers
  - can contain any initialization logic, that should be executed every time when a new object is created for the class
  -

- Static Constructor
  - Initializes static fields; cannot access instance fields
  - Executes only once, i.e. when first object is created for the class or when the class is accessed for the first time during the execution of Main method
  - public by default. Access modifier cannot be changed.
  - can contain any initialization logic, that should be executed only once i.e. when a new object is created for the class.
