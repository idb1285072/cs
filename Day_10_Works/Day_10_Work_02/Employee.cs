public class Employee
{
    private int _id;
    private string _name;
    protected string _location;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Location
    {
        get { return _location; }
        set { _location = value; }
    }
}