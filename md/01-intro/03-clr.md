# .NET Runtime and CLR

## What is CLR?

- Common Language Runtime (CLR)
- **Execution Engine** for all .NET Language
- **Code-Execution Environment** that executes **all types of .NET applications**
- Application developed in any language runs based on CLR only
- CLR is a part of .NET Framework; **pre-install in windows**
- CLR provides
  - Class Loaders
  - Memory Manager
  - Garbage Collector
  - JIT (Just-In-Time) Compiler
  - Exception Manager
  - Thread Manager
  - Security Manager

## CLR Components:

- Class Loaders / Assembly Loaders:
  - Loading classes from compiled source code to memory.
  - Loads a class, when it is needed (before creating object)
- Memory Manager:
  - Allocating necessary memory for object
  - When an object is created in the code, certain amount of memory will be allocated for the object in application's heep
- Garbage Collector:
  - Freeing (deleting) memory of objects
  - Identifies all unreferenced objects and delete then in memory (RAM)
- JIT (Just-In-Time) Compiler:
  - Convert the MSIL Code into Native Machine Language
  - Compiles the code of a class, when it is needed (before executing that particular class)
- Exception Manager:
  - Raise notification while run-time errors.
  - Creates exception logs
- Thread Manager:
  - Create threads (background process) to execute the code
  - The entire program is treated as "Main thread"
  - Developer can create sub threads (child threads) to do background processes
- Security Manager:
  - Verifies whether the application has permission to access system resources or not
  - Before executing the application, it verifies whether the application has not attacked by malicious programs and has necessary permissions to access files / folders and hardware resources.

## .NET Runtime vs CLR

- .NET apps cannot directly run on OS. CLR = execution environment
- **.NET Runtime** = the runtime used by modern .NET (.NET Core, .NET 5+)
- **CLR (Common Language Runtime)** = the runtime used by the .NET Framework.
- Both perform similar core jobs: **execute .NET code, manage memory/GC, handle exceptions, provide type safety, etc.**
- **Old .NET Framework:**
  `source code → compiler → IL → CLR → machine code`
- **Modern .NET:**
  `source code → compiler → IL → .NET Runtime → machine code`
