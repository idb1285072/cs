// ClassName don't need same as FileName
// Every C# Application has at least one class
// ClassName can be whatever for the Main method.
class Sample
{
    /*
    Main Method is the Entry Point
    CaseSensitive (must capital M of Main)
    static method
    return type - void, int, Task, Task<int>
          - for most of the application, return type is void
          - if return type int, return to OS
              - return 0 means program execute successfully
              - return 1 indecates program has some error
    */
    static void Main()
    {
        System.Console.WriteLine("Hello World!");
        System.Console.ReadKey();
    }
}