class Sample
{
    static void Main()
    {
        // Print messages line by line
        System.Console.WriteLine("Welcome");
        System.Console.WriteLine("to");
        System.Console.WriteLine("C# Programming");

        // Print messages side by side
        System.Console.Write("Welcome ");
        System.Console.Write("to ");
        System.Console.Write("C# Programming");

        // Wait for pressing a key before closing the console window
        System.Console.ReadKey();

        // Clear the screen
        System.Console.Clear();

        // Print messages line by line again
        System.Console.WriteLine("Thank you.");
        System.Console.ReadKey();
    }
}