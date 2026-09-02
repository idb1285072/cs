// Generic class example
public class User<T1, T2>
{
    public T1 RegistrationStatus;
    public T2 Age; 
}

// Generic constraints example
public abstract class Student
{
    public abstract int Marks { get; set; }
}

public class GraduateStudent : Student
{
    public override int Marks { get; set; }
}
public class PostGraduateStudent: Student
{
    public override int Marks { get; set; }
}


public class MarksPrinter<T> where T: Student
{
    public T student;
    public void PrintMarks()
    {
        Student temp = (Student)student;
        System.Console.WriteLine($"Marks: {temp.Marks}");
    }
}

// Generic method example
public class Employee
{
    public int Salary;
}
public class Student1
{
    public int Marks;
}
public class Sample
{
    public void PrintData<T>(T data) where T : class
    {
        if(data.GetType() == typeof(Employee))
        {
            Employee emp = (Employee)(object)data;
            System.Console.WriteLine($"Salary: {emp.Salary}");
        }
        else if(data.GetType() == typeof(Student1))
        {
            Student1 stu = (Student1)(object)data;
            System.Console.WriteLine($"Marks: {stu.Marks}");
        }
    }
}