## What?
- Switch Expression is a short-form of switch-case, which is used to check the value of source variable; assign value into result value based on the value of source variable

## How?
```cs
sourceVariable switch
{
  value1 => result1;
  value2 => result2;
  ...
  _ => defaultValue;
}
```