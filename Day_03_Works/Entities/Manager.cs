public class Manager : Employee
{
    // Field
    private string _department;

    // Constructor
    public Manager(
        int employeeId,
        string employeeName,
        string location,
        string department)
        : base(employeeId, employeeName, location)
    {
        _department = department;
    }

    // Property
    public string Department
    {
        get { return _department; }
        set { _department = value; }
    }

    // Method
    public long GetTotalSalesOfTheYear()
    {
        return 1000000;
    }

    public string GetFullDepartmentName()
    {
        //return Department + " at " + base.Location;
        return Department + " at " + base._location;
    }

    // Method hiding
    public new string GetHealthInsuranceAmount()
    {
        return "Health Insurance Amount: $5500";
    }

    // Method overriding
    public sealed override string GetHealthInsuranceDetails()
    {
        System.Console.WriteLine(base.GetHealthInsuranceDetails());
        return "Health Insurance Details: Premium Plan";
    }
}

public class BranchedManager : Manager
{
    // Constructor
    public BranchedManager(
        int employeeId,
        string employeeName,
        string location,
        string department)
        : base(employeeId, employeeName, location, department)
    {
    }
    // Method overriding
    //public override string GetHealthInsuranceDetails()
    //{
    //    return "Health Insurance Details: Premium Plan with Branch Benefits";
    //}
}