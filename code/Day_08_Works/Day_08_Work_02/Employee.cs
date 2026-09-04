public class Employee
{
    private int _id;
    private string _name;
    private string _job;
    private decimal _salary;
    public static string companyName;

    //public Employee()
    //{
    //    this.id = 1001;
    //    this.name = "No Name";
    //    this.job = "Some Job Title";
    //}

    public Employee(int id, string name, string job)
    {
        this._id = id;
        this._name = name;
        this._job = job;
    }

    public Employee(int id, string name, decimal salary)
    {
        this._id = id;
        this._name = name;
        this._salary = salary;
    }

    public Employee(int id)
    {
        this._id = id;
    }

    public Employee()
    {

    }

    // by default public; cannot use access modifier
    // no parameter; not return
    static Employee()
    {
        companyName = "Tech Solutions Inc.";
    }


    // Properties
    public int Id
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string Name
    {
        get { return this._name; }
        set
        {
            if (value.Length < 3)
            {
                throw new System.ArgumentException("Name must be at least 3 characters long.");
            }
            if (value.Length > 20)
            {
                throw new System.ArgumentException("Name cannot be more than 20 characters long.");
            }
            this._name = value;
        }
    }

    public string Job
    {
        get { return this._job; }
        set { this._job = value; }
    }

    public decimal Salary
    {
        get { return this._salary; }
    }

    public string NativePlace { get; set; }

    //private string _nativePlace;
    //public string NativePlace
    //{
    //    get { return _nativePlace; }
    //    set { _nativePlace = value; }
    //}


    private string[] _brand = new string[] { "Raj", "Raja"};

    // indexer
    public string this[int index]
    {
        get { return _brand[index]; }
        set { this._brand[index] = value; }
    }
}