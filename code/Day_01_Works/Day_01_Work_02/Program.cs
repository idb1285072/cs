class Sample
{
    static void Main()
    {
        // Set Title
        System.Console.Title = "Console Class";

        // Display message side by side
        System.Console.Write("Welcome ");
        System.Console.Write(" to");
        System.Console.Write(" C# Program.");

        // Empty Line
        System.Console.WriteLine();
        System.Console.WriteLine();

        // Display message line by line
        System.Console.WriteLine("Welcome");
        System.Console.WriteLine("to");
        System.Console.WriteLine("C# Program.");

        System.Console.ReadKey();

        Color.BackgroundColor.ColorFullPage(System.ConsoleColor.DarkBlue, System.ConsoleColor.DarkYellow);

        System.Console.BackgroundColor = System.ConsoleColor.White;
        System.Console.ForegroundColor = System.ConsoleColor.DarkGreen;

        string message = "Welcome to C# Program.";
        System.Console.CursorLeft = (System.Console.WindowWidth - message.Length) / 2;
        System.Console.WriteLine(message);

        System.Console.WriteLine();
        System.Console.WriteLine();

        // Change colors
        System.Console.ForegroundColor = System.ConsoleColor.Gray;
        System.Console.BackgroundColor = System.ConsoleColor.DarkMagenta;
        System.Console.CursorTop = System.Console.WindowHeight / 2 - 3;

        System.Console.WriteLine(Color.BackgroundColor.GetTextFullLine("Welcome"));
        System.Console.WriteLine(Color.BackgroundColor.GetTextFullLine("to"));
        System.Console.WriteLine(Color.BackgroundColor.GetTextFullLine("C# Program."));

        System.Console.CursorTop -= 3;
        System.Console.ReadKey();
        System.Console.ResetColor();
        System.Console.Clear();

        System.Console.Write("Enter your name: ");
        string username = System.Console.ReadLine();

        System.Console.ResetColor();
        System.Console.BackgroundColor = System.ConsoleColor.White;
        System.Console.ForegroundColor = System.ConsoleColor.DarkGreen;
        System.Console.Clear();

        System.Console.SetCursorPosition((System.Console.WindowWidth - username.Length) / 2, System.Console.WindowHeight / 2);

        System.Console.WriteLine($"Thanks {username}");
        System.Console.ReadKey();

        System.Console.ResetColor();
        System.Console.Clear();
        System.Console.WriteLine("Exit from the Program.");
        System.Console.ReadKey();
    }
}