class Loop
{
    static void Main()
    {
        // while
        int i = 1;
        while (i <= 10)
        {
            System.Console.WriteLine(i);
            i++;
        }

        // do while
        int j = 1;
        do
        {
            System.Console.WriteLine(j);
            j++;
        } while (j <= 10);

        // for loop
        for (int k = 0; k < 10; k++)
        {
            System.Console.WriteLine(k);
        }

        int l = 0;
        for (; l < 10; l++)
        {
            System.Console.WriteLine(l);
        }

        // Nested Loop
        for (int m = 1; m <= 10; m++)
        {
            for(int n=1; n<= m; n++)
            {
                System.Console.Write(n + " ");
            }
            System.Console.WriteLine();
        }
        System.Console.ReadKey();
    }
}