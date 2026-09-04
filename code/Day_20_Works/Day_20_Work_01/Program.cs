class Program
{
    static void Main()
    {
        Sample sample = new Sample();
        MyDelegate myDelegate;
        myDelegate = sample.Add;
        System.Console.WriteLine(myDelegate.Invoke(1, 2));

        // Multicast delegate
        MyMultiCastDelegate myMultiCastDelegate;
        myMultiCastDelegate = sample.PrintAdd;
        myMultiCastDelegate += sample.PrintMultiply;
        myMultiCastDelegate.Invoke(3, 4);
        /*
          For multicast delegates:
            - all the methods must have the same parameters and return type
            - return type should be void
         */

        System.Console.ReadKey();
    }
}
