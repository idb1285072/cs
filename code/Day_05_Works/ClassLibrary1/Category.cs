public struct Category
{
    // private fields
    private int _categoryId;
    private string _categoryName;

    // constructor
    public Category(int categoryId, string categoryName)
    {
        _categoryId = categoryId;
        _categoryName = categoryName;
    }

    // public properties
    public int CategoryId
    {
        get { return _categoryId; }
        set
        {
            if (value >= 1 && value <= 1000)
            {
                _categoryId = value;
            }
        }
    }
    public string CategoryName
    {
        get { return _categoryName; }
        set
        {
            if (value.Length < 50)
            {
                _categoryName = value;
            }
        }
    }

    // methods
    public int GetCategoryNameLength()
    {
        return _categoryName.Length;
    }
}