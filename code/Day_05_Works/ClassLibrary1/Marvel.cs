public readonly struct Marvel
{
    // private fields
    private readonly string _characterName;

    public Marvel(string characterName)
    {
        _characterName = characterName;
    }

    // public properties
    public string CharacterName
    {
        get { return _characterName; }
    }

    // public method
    public void PrintCharacterName()
    {
        System.Console.WriteLine($"Character Name: {_characterName}");
    }
}