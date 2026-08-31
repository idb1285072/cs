class JumpingControlStatement
{
    static void Main()
    {
        // break
        for (int i = 0; i <= 10; i++)
        {
            if (i == 6) break;
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

        // continue
        for (int i = 0; i <= 10; i++)
        {
            if (i == 6) continue;
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();

        // goto
        System.Console.WriteLine("USA");
        System.Console.WriteLine("UK");
        System.Console.WriteLine("BD");
        goto myLabel;
        System.Console.WriteLine("France");
        System.Console.WriteLine("Italy");
        System.Console.WriteLine("Iran");
    myLabel:
        System.Console.WriteLine("Nepal");
        System.Console.WriteLine("Dubai");


        System.Console.ReadKey();
    }
}