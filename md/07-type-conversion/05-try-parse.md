
# TryParse

## What?

- Convert from string to numerical type but check the source value before attempting to parse

## 💡

- If the source is invalid, it returns false; It doesn't raise any exception in this case.
- It avoids FormatException.
- If the source is valid; Convert string value into numerical type and store it in out directional variable and return `true`
- If string value contains alphabets, spaces or special characters, store in `out` parameter `0` and return `false`

## Syntax

```cs
bool variable = DestinationType.TryParse(sourceValue, out DestinationVariable);
```

## Example

```cs
System.Console.Write("Enter a number: ");
string s = System.Console.ReadLine();

bool b = int.TryParse(s, out int n);

if(b)
{
  System.Console.WriteLine("Conversion is successfully");
  System.Console.WriteLine(n);
}
else
{
  System.Console.WriteLine("Conversion Fail");
}

```
