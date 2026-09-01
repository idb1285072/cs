# .NET Compilation and Execution Pipeline

## What?

- Common Language Infrastructure (CLI) = the blueprint/specification.
- Common Language Runtime (CLR) = Microsoft’s actual runtime engine that follows the CLI standard.

## Why?

- Ensures cross‑language interoperability in .NET

## Flow

> source code → compiler → IL → CLR → machine code

Here,

- source code
  - human-readable
  - written code in a .NET language such as C#
- compiler
  - The compiler is .NET language specific such as for C#, the compiler is **Roslyn**
  - The appropriate compiler converts the source code into IL (Intermediate Language) + metadata
  - The compiler performs tasks such as:
    - Syntax checking
    - Type checking
    - Detecting compiler-time errors
    - Generating IL
    - Generating metadata
  - IL is language neutral
- Assembly
  - The generated IL and metadata are packaged into an assembly, usually: `.dll` or `.exe`
    - `.exe` (**Executable Assembly**), an application that can be **started directly**
    - `.dll` (**Library Assembly**), a **reusable library** that is normally loaded by another application.
- CLR
  - CLR loads the IL.
  - CLR provides an JIT (Just-In-Time) compiler that converts IL into native machine code.
- machine code
  - The machine code runs on the processor or CPU

## How to see IL Code?

- Press Windows btn. write **Developer Command Prompt for vs** and open.
- command `ildasm` (Intermediate Language Disassembler)
- File → Open
- path → bin → debug → .exe file
- double click on class or method to see IL code
