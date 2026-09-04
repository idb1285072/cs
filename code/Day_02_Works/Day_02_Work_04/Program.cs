class Constructor
{
    static void Main()
    {
        Employee emp1, emp2, emp3;

        emp1 = new Employee();
        emp2 = new Employee(102, "Raja", "Asst. Manager");
        emp3 = new Employee(103, "Rana") { job = "Cleck"};
        emp1.employeeId = 101;
        emp1.employeeName = "Raj";
        emp2.job = "Manager";
        //emp3.job = "Cleck";

        System.Console.WriteLine("Company Name: " + Employee.companyName);
        System.Console.WriteLine();
        System.Console.WriteLine("Employee 1:");
        System.Console.WriteLine("Id: " + emp1.employeeId);
        System.Console.WriteLine("Name: " + emp1.employeeName);
        System.Console.WriteLine("Job: " + emp1.job);
        System.Console.WriteLine();

        System.Console.WriteLine("Employee 2:");
        System.Console.WriteLine("Id: " + emp2.employeeId);
        System.Console.WriteLine("Name: " + emp2.employeeName);
        System.Console.WriteLine("Job: " + emp2.job);
        System.Console.WriteLine();

        System.Console.WriteLine("Employee 3:");
        System.Console.WriteLine("Id: " + emp3.employeeId);
        System.Console.WriteLine("Name: " + emp3.employeeName);
        System.Console.WriteLine("Job: " + emp3.job);
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
}