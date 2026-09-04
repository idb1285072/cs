using System;

class Program
{
    static void Main()
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        // Subscribe to the event
        publisher.myEvent += subscriber.Add;

        // annonymous method
        publisher.myEvent += delegate (int a, int b)
        {
            System.Console.WriteLine($"Annonimus: {a} + {b} = {a + b}");
        };

        // lambda expression
        publisher.myEvent += (a, b) => System.Console.WriteLine($"Lambda: {a} + {b} = {a + b}");

        // Raise the event
        publisher.RaiseEvent(5, 10);


        System.Console.ReadKey();
    }
}
