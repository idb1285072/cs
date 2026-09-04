public class SalesMan : Employee
{
    // Field
    private string _region;

    // Constructor
    public SalesMan(
        int employeeId,
        string employeeName,
        string location,
        string region)
        : base(employeeId, employeeName, location)
    {
        _region = region;
    }

    // Property
    public string Region
    {
        get { return _region; }
        set { _region = value; }
    }

    // Method
    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }
}