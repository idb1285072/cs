
class Indexer
{
    static void Main()
    {
        Car car = new Car();
        car[0] = "BMW";
        System.Console.WriteLine(car[0]); // Output: BMW
        System.Console.WriteLine(car[1]);

        car["first"] = "Mercedes";
        System.Console.WriteLine(car["first"]); // Output: Mercedes

        System.Console.ReadKey();
    }
}


public class Car
{
    // private field to hold the brands array
    private string[] _brands = new string[] { "Toyota", "Honda", "Ford", "Chevrolet", "Nissan" };
    private string[] _names = new string[] {"first", "second", "third", "fourth", "fifth"};

    // public indexer to access the brands array
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < _brands.Length)
            {
                return _brands[index];
            }
            else
            {
                throw new System.IndexOutOfRangeException("Index is out of range.");
            }
        }
        set
        {
            if (index >= 0 && index < _brands.Length)
            {
                _brands[index] = value;
            }
            else
            {
                throw new System.IndexOutOfRangeException("Index is out of range.");
            }
        }
    }

    // indexer overloading
    public string this[string name]
    {
        get
        {
            return _brands[System.Array.IndexOf(_names, name)];
        }
        set
        {
            _brands[System.Array.IndexOf(_names, name)] = value;
        }
    }
}