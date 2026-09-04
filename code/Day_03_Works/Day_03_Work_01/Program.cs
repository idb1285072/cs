class Inheritance
{
    static void Main()
    {
        Employee employee = new Employee(101, "John Doe", "New York");
        //employee.EmployeeId = 101;
        //employee.EmployeeName = "John Doe";
        //employee.Location = "New York";

        System.Console.WriteLine("Employee Details:");
        System.Console.WriteLine($"Employee ID: {employee.EmployeeId}");
        System.Console.WriteLine($"Employee Name: {employee.EmployeeName}");
        System.Console.WriteLine($"Location: {employee.Location}");
        System.Console.WriteLine();

        Manager manager = new Manager(102, "Jane Smith", "Los Angeles", "Sales");
        //manager.EmployeeId = 102;
        //manager.EmployeeName = "Jane Smith";
        //manager.Location = "Los Angeles";
        //manager.Department = "Sales";
        System.Console.WriteLine("Manager Details:");
        System.Console.WriteLine("Manager ID: " + manager.EmployeeId);
        System.Console.WriteLine("Manager Name: " + manager.EmployeeName);
        System.Console.WriteLine("Location: " + manager.Location);
        System.Console.WriteLine("Department: " + manager.Department);
        System.Console.WriteLine("Total Sales of the Year: " + manager.GetTotalSalesOfTheYear());
        System.Console.WriteLine("Full Department Name: " + manager.GetFullDepartmentName());
        System.Console.WriteLine();

        SalesMan salesMan = new SalesMan(103, "John Doe", "New York", "North");
        //salesMan.EmployeeId = 103;
        //salesMan.EmployeeName = "John Doe";
        //salesMan.Location = "New York";
        //salesMan.Region = "North";
        System.Console.WriteLine("SalesMan Details:");
        System.Console.WriteLine("SalesMan ID: " + salesMan.EmployeeId);
        System.Console.WriteLine("SalesMan Name: " + salesMan.EmployeeName);
        System.Console.WriteLine("Location: " + salesMan.Location);
        System.Console.WriteLine("Region: " + salesMan.Region);
        System.Console.WriteLine("Sales of the Current Month: " + salesMan.GetSalesOfTheCurrentMonth());
        System.Console.WriteLine();

        System.Console.WriteLine("Parent Class: " + employee.GetHealthInsuranceAmount());
        System.Console.WriteLine("Child Class: " + manager.GetHealthInsuranceAmount());

        System.Console.WriteLine();

        System.Console.WriteLine("Parent Class: " + employee.GetHealthInsuranceDetails());
        System.Console.WriteLine("Child Class: " + manager.GetHealthInsuranceDetails());
        System.Console.ReadKey();
    }
}

