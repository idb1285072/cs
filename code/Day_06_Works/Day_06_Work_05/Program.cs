public class MarksCalculation
{
    public void CalculatePercentage(Student student)
    {
        CalculateHelper helper = new CalculateHelper();
        student.Percentage = helper.Multiply(student.TotalMarks, 100) / student.MaxMarks;
    }

    public class CalculateHelper
    {
        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}


class NestClass
{
    static void Main()
    {
        Student student = new Student
        {
            TotalMarks = 450,
            MaxMarks = 500
        };
        MarksCalculation marksCalculation = new MarksCalculation();
        marksCalculation.CalculatePercentage(student);
        System.Console.WriteLine($"Percentage: {student.Percentage}%");

        MarksCalculation.CalculateHelper helper = new MarksCalculation.CalculateHelper();
        System.Console.WriteLine("Multiplication Result: " + helper.Multiply(5, 10));
    }
}