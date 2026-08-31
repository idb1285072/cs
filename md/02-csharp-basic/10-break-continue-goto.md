# break

## 💡 Rules

- `break` statement is used to stop the execution of current loops
- It is recommended to keep the `break` statement, inside if statement
- It can be used any type of loop (while, do-while, for)

## 🧩 Syntax

```cs
for (initialization; condition1; increment)
{
  if (condition2)
  {
    break;
  }
  // for block code here
}
```

## Example

```cs
for(int i = 1; i <= 10; i++)
{
  if (i == 6)
  {
    break;
  }
  System.Console.WriteLine(i);
}
// Output: 1, 2, 3, 4, 5
```

# continue

## 💡 Rules

- Used to skip the execution of current iteration; and jump to the next iteration
- It is recommended to keep the `continue` statement, inside if statement
- It can be used in any type of loop (while, do-while, for)

## 🧩 Syntax

```cs
for (initialization; condition1; increment)
{
  if (condition2)
  {
    continue;
  }
  // for block code here
}
```

## Example

```cs
for(int i = 1; i <= 10; i++)
{
  if (i == 6)
  {
    continue;
  }
  System.Console.WriteLine(i);
}
// Output: 1, 2, 3, 4, 5, 7, 8, 9, 10
```

# goto

## 🧩 Syntax

```cs
statement1;
statement2;
labelName:
statement3;
statement4;
goto labelName;
```

```cs
statement1;
statement2;
goto labelName;
statement3;
labelName:
statement4;
```

## Example

```cs
System.Console.WriteLine("one");
System.Console.WriteLine("two");
myLabel:
System.Console.WriteLine("three");
System.Console.WriteLine("four");
goto myLabel;
System.Console.WriteLine("five");
// Output: one two three four three four three four ...
```

```cs
System.Console.WriteLine("one");
System.Console.WriteLine("two");
goto myLabel;
System.Console.WriteLine("three");
System.Console.WriteLine("four");
myLabel:
System.Console.WriteLine("five");
// Output: one two five
```
