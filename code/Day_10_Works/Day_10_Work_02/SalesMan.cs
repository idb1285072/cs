public class SalesMan : Employee
{
    private string _region;
    public string Region
    {
        get { return _region; }
        set { _region = value; }
    }

    public long GetSalesOfTheCurrentMonth()
    {
        return 2000;
    }
}