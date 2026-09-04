class GenericMethod
{
    static void Main()
    {
        Sample sample = new Sample();
        Employee employee = new Employee() { Salary = 50000 };
        Student1 student = new Student1() { Marks = 85 };
        sample.PrintData(employee);
        sample.PrintData(student);
        System.Console.ReadKey();
    }
}