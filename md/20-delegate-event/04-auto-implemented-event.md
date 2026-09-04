## What?

- Auto-implemented Events provide a shortcut syntax to create events with less code
- In this case, you need not create add and remove accessors; the compiler does the same automatically

## Syntax?

```cs
class Publish
{
  public event MyDelegateType MyEvent;
}
```

## Rule

- You also not required to create a private multi-cast delegate; the compiler does the same automatically
- Disadvantage: We cannot define custom logic for add accessor and remove accessor
