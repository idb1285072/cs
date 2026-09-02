class GenericClass
{
    static void Main()
    {
        User<int, int> user1 = new User<int, int>();
        user1.RegistrationStatus = 1;
        user1.Age = 25;

        User<bool, string> user2 = new User<bool, string>();
        user2.RegistrationStatus = false;
        user2.Age = "30-33";

        System.Console.WriteLine($"User1 Registration Status: {user1.RegistrationStatus}");
        System.Console.WriteLine($"User1 Age: {user1.Age}");
        System.Console.WriteLine($"User1 Registration Status: {user2.RegistrationStatus}");
        System.Console.WriteLine($"User1 Age: {user2.Age}");
        System.Console.ReadKey();
    }
}