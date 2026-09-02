class ReadOnlyStruct
{
    static void Main()
    {
        Marvel marvel = new Marvel("Spider-Man");
        System.Console.WriteLine(marvel.CharacterName);
        marvel.PrintCharacterName();
        System.Console.ReadKey();
    }
}