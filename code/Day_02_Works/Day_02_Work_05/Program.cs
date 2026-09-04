class Property
{
    static void Main()
    {
        Employee emp1, emp2, emp3;
        emp1 = new Employee();
        emp2 = new Employee(102, "Raja", "Asst. Manager");
        emp3 = new Employee(103, "Rana") { Job = "Cleck" };
        emp1.NativePlace = "Hyderabad";

        System.Console.WriteLine("Company Name: " + Employee.CompanyName);
        System.Console.WriteLine();
        System.Console.WriteLine("Employee 1:");
        System.Console.WriteLine("Id: " + emp1.EmployeeId);
        System.Console.WriteLine("Name: " + emp1.EmployeeName);
        System.Console.WriteLine("Job: " + emp1.Job);
        System.Console.WriteLine("Native Place: " + emp1.NativePlace);
        System.Console.WriteLine();
        System.Console.WriteLine("Employee 2:");
        System.Console.WriteLine("Id: " + emp2.EmployeeId);
        System.Console.WriteLine("Name: " + emp2.EmployeeName);
        System.Console.WriteLine("Job: " + emp2.Job);
        System.Console.WriteLine("Native Place: " + emp2.NativePlace);
        System.Console.WriteLine();
        System.Console.WriteLine("Employee 3:");
        System.Console.WriteLine("Id: " + emp3.EmployeeId);
        System.Console.WriteLine("Name: " + emp3.EmployeeName);
        System.Console.WriteLine("Job: " + emp3.Job);
        System.Console.WriteLine("Native Place: " + emp3.NativePlace);
        System.Console.WriteLine();
        System.Console.ReadKey();
    }


   
}

public class Employee
{
    private int _employeeId;
    private string _employeeName;
    private string _job;
    private decimal _salary;
    private decimal _tax;

    private static string _companyName;
    //public Employee()
    //{
    //    employeeId = 101;
    //    employeeName = "No Name";
    //    job = "Some job title";
    //}

    public Employee()
    {
        EmployeeId = 1;
    }

    public Employee(int employeeId, string employeeName)
    {
        this.EmployeeId = employeeId;
        this.EmployeeName = employeeName;
    }

    public Employee(int employeeId, string employeeName, string job)
    {
        this.EmployeeId = employeeId;
        this.EmployeeName = employeeName;
        this.Job = job;
    }

    // Static Constructor
    static Employee()
    {
        _companyName = "ABC Industries";
    }

    public int EmployeeId
    {
        get
        {
            return _employeeId;
        }
        set
        {
            if (value > 0 && value < 1000)
            {
                _employeeId = value;
            }
        }
    }

    public string EmployeeName
    {
        set
        {
            if (value.Length <= 20)
            {
                _employeeName = value;
            }
        }
        get
        {
            return _employeeName;
        }
    }

    public string Job
    {
        set
        {
            _job = value;
        }
        get
        {
            return _job;
        }
    }

    public static string CompanyName
    {
        set
        {
            _companyName = value;
        }
        get
        {
            return _companyName;
        }
    }

    // Read-only property
    public decimal Salary
    {
        get
        {
            return _salary;
        }
    }

    // Write-only property
    public decimal Tax
    {
        set
        {
            _tax = value;
        }
    }

    public decimal CalculateNetSalary()
    {
        return _salary - _tax;
    }

    // Auto-implemented property
    public string NativePlace { internal get; set; } = "New York";
}