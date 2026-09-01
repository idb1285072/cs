public class Employee
{
    // Field
    private int _employeeId;
    private string _employeeName;
    protected string _location;

    // Constructor
    public Employee(
        int employeeId,
        string employeeName,
        string location)
    {
        _employeeId = employeeId;
        _employeeName = employeeName;
        _location = location;
    }

    // Property
    public int EmployeeId
    {
        get { return _employeeId; }
        set { _employeeId = value; }
    }
    public string EmployeeName
    {
        get { return _employeeName; }
        set { _employeeName = value; }
    }
    public string Location
    {
        get { return _location; }
        set { _location = value; }
    }

    // Method hiding
    public string GetHealthInsuranceAmount()
    {
        return "Health Insurance Amount: $5000";
    }

    // Method overriding
    public virtual string GetHealthInsuranceDetails()
    {
        return "Health Insurance Details: Basic Plan";
    }
}