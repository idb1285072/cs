class Sample
{
    static void Main()
    {
        Employee emp1 = new Employee(1001, "Raj Khan", "Software Developer");
        Employee emp2 = new Employee(1002, "Anita Singh", "Project Manager");
        Employee emp3 = new Employee(1003, "John Doe", "QA Engineer");

        System.Console.WriteLine("Company: " + Employee.companyName);
        System.Console.WriteLine("Employee 1: ");
        System.Console.WriteLine("ID: " + emp1.Id);
        System.Console.WriteLine("Name: " + emp1.Name);
        System.Console.WriteLine("Job: " + emp1.Job);
        System.Console.WriteLine();
        System.Console.WriteLine("Employee 2: ");
        System.Console.WriteLine("ID: " + emp2.Id);
        System.Console.WriteLine("Name: " + emp2.Name);
        System.Console.WriteLine("Job: " + emp2.Job);
        System.Console.WriteLine();
        System.Console.WriteLine("Employee 3: ");
        System.Console.WriteLine("ID: " + emp3.Id);
        System.Console.WriteLine("Name: " + emp3.Name);
        System.Console.WriteLine("Job: " + emp3.Job);

        // Object Initializer Syntax
        Employee emp4 = new Employee(1004) { Name = "Alice Johnson", Job = "UI/UX Designer" };
        Employee emp5 = new Employee() { Id = 1005, Name = "Bob Smith", Job = "DevOps Engineer" };

        Employee emp6 = new Employee();
        emp6.Id = 1006;
        emp6.Name = "Charlie Brown";
        emp6.Job = "Database Administrator";

        Employee emp7 = new Employee(1007, "David Lee", 75000m);
        emp7.Job = "System Analyst";
        System.Console.WriteLine("Employee 7 Salary: " + emp7.Salary);

        // Indexer
        emp7[0] = "Rana";
        System.Console.WriteLine("Indexer: " + emp7[1]);

        System.Console.ReadKey();
    }
}