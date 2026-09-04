public class Manager : Employee
{
    private string _department;
    public string Department
    {
        get { return _department; }
        set { _department = value; }
    }

    public long GetTotalSalesOfTheYear()
    {
        return 10000;
    }

    public string GetFullDepartmentName()
    {
        return this._department + " at " + base._location; 
        // base for access parent class member
    }
}