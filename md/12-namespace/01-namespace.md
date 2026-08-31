# Namespace

## What?

- A namespace is used **to organize** related classes, interfaces, structs, etc. and **avoid name conflicts**.
- **collection of classes** and other types like interface, structs, enums, delegates etc.
- like a **logical folder** that groups related types

## Why?

- 📁 Organize code
- 🚫 Avoid naming conflicts
- 🔗 Make code easier to manage in large projects

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
