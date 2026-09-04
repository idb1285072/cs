class Program
{
    static void Main()
    {
        Employee emp1 = new Employee();
        emp1.Id = 1;
        emp1.Name = "Test";
        emp1.Location = "Dhaka";

        Manager manager = new Manager();
        manager.Id = 1;
        manager.Name = "Test";
        manager.Location = "Dhaka";
        manager.Department = "Accounting";

        SalesMan salesMan = new SalesMan();
        salesMan.Id = 1;
        salesMan.Name = "Test";
        salesMan.Location = "New York";
        salesMan.Region = "New York";

        System.Console.WriteLine("Department Name: " + manager.GetFullDepartmentName());
    }
}