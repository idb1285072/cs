class GenericConstrain
{
    static void Main()
    {
        MarksPrinter<Student> studentPrinter = new MarksPrinter<Student>();
        MarksPrinter<GraduateStudent> graduateStudentPrinter = new MarksPrinter<GraduateStudent>();
        MarksPrinter<PostGraduateStudent> postGraduateStudentPrinter = new MarksPrinter<PostGraduateStudent>();

        System.Console.ReadKey();
    }
}