public class Person: System.Object
{
    public string PersonName { get; set; }
    public string EmailAddress { get; set; }

    public override bool Equals(object obj)
    {
        Person person = obj as Person;
        if(this.PersonName== person.PersonName && this.EmailAddress == person.EmailAddress) 
        {
            return true;
        }
        return false;
    }

    override public int GetHashCode()
    {
        return base.GetHashCode();
    }

    override public string ToString()
    {
        return $"Person Name: {this.PersonName}, Email Address: {this.EmailAddress}";
    }
}

public class  Supplier: Person
{
    
}