## What?

- EventHandler is a pre-defined delegate type, which has two parameters called object sender and `EventArgs e` and no return.

## How?

```cs
public event EventHandler EventName;
```

## Parameters

- `object sender`: Represents the source object, where the from where the event is originally raised
- `EventArgs e`: Represents additional parameters to pass to event handler method. It is recommended to create a child class for `EventArgs` class
- 
