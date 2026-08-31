# Parse

## What?

- convert from string type to numerical type

## 💡

- The source value must contain digits only, shouldn't contain spaces, alphabets or special characters.
- If the source value is invalid, it raises FormatException

## Example

```cs
string a = "100";
int b = int.Parse(a);
```
