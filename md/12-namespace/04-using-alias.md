# `using` alias

## What?

- Nickname or shortname of NamespacePath

## How?

```cs
using AliasName = NamespacePath;
```

## Why?

- Avoid long namespace names
- Resolve naming conflicts
- Make code shorter

## Rules

- long namespace path into shortcut name
- namespace name abgiguity (two classes with same name in two different namespaces and namespaces are imported in the same file)
