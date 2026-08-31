class Sample
{
    static void Main()
    {
        Customer c1, c2;

        new Customer(); // Create Object in Heap but not ref in Stack, so cannot access

        c1 = new Customer();
        c2 = new Customer();



    }
}