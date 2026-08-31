public class Employee
{
    public int employeeId;
    public string employeeName;
    public string job;

    public static string companyName;
    //public Employee()
    //{
    //    employeeId = 101;
    //    employeeName = "No Name";
    //    job = "Some job title";
    //}

    public Employee()
    {
        employeeId = 1;
    }

    public Employee(int employeeId, string employeeName)
    {
        this.employeeId = employeeId;
        this.employeeName = employeeName;
    }

    public Employee(int employeeId, string employeeName, string job)
    {
        this.employeeId = employeeId;
        this.employeeName = employeeName;
        this.job = job;
    }

    // Static Constructor
    static Employee()
    {
        companyName = "ABC Industries";
    }
}