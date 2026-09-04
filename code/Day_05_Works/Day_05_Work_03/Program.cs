class UltimateBaseClass
{
    static void Main()
    {
        System.Object obj;

        obj = new Person() { PersonName = "John Doe", EmailAddress = "johndoe@example.com" };

        System.Console.WriteLine(obj.Equals(new Person() { PersonName = "John Doe", EmailAddress = "johndoe@example.com" }));
        System.Console.WriteLine(obj.GetHashCode());
        System.Console.WriteLine(obj.ToString());
        System.Console.WriteLine(obj.GetType().ToString());

        System.Console.ReadKey();
    }
}