# while

## 🧩 Syntax

```cs
initialization;
while (condition)
{
  // while block
  // increment/decrement
}
```

Example

```cs
int i = 1;
while (i<=10)
{
  System.Console.WriteLine(i);
  i++;
}
```

# do-while

## 💡 Rule

- Used to executes a set of statements; as long as the condition is `true`
- Once the condition is `false`, it will exit from the while loop
- It is same as While Loop; but the difference is:
  - It executes at least one time even though the condition is false, because it doesn't check the condition for the first time
  - second time onwards, it is same as While Loop.

## 🧩 Syntax

```cs
initialization;
do
{
  // do-while block
  // increment / decrement
} while (condition);
```

# for Loop

## 🧩 Syntax

```cs
for (initialization; condition; increment)
{
  // for block
}
```

# Nested Loop

- One loop inside another loop
