public class Sample
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    // target method for the multi-cast delegate
    public void PrintAdd(int a, int b)
    {
        System.Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
    }
    public void PrintMultiply(int a, int b)
    {
        System.Console.WriteLine($"The product of {a} and {b} is: {a * b}");
    }
}