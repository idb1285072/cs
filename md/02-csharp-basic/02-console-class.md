# Console Class

- I/O operations
- **static class**: can **access** all the member **without creating object**
- `System` namespace

```cs
// I/O
System.Console.WriteLine();
System.Console.Write();
System.Console.ReadLine();
System.Console.ReadKey();

// Clear Screen
System.Console.Clear();

// Set Console Text Color
System.Console.ForegroundColor = System.ConsoleColor.Green;
// Set Console Background Color
System.Console.BackgroundColor = System.ConsoleColor.White;
// Restores the default colors.
System.Console.ResetColor()

// Set Cursor Position
System.Console.SetCursorPosition(10, 5);
// Get current Cursor Position
int x = System.Console.CursorLeft;
int y = System.Console.CursorTop;

// Set Title
System.Console.Title = "My Application";
```

> **Note:** For full mouse support use `Terminal.Gui` Nuget.
