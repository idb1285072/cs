# Namespace

## What?

- collection of classes and other types like interface, structs, enums, delegates etc.
- like a **logical folder** that groups related types

## Why?

- organize code
- avoid name conflicts

## How?

```cs
// Create namespace
namespace NamespaceName
{
  class ClassName
  {

  }
}

// access namespace member
NamespaceName.MemberName
```

## Rules:

- A namespace doesn't need to match the folder name. The folder structure and namespace are separate concepts.
- A namespace can exist accross the multiple files.
- Namespace can be nested
