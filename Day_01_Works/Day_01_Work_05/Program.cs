class ConditionalStatement
{
    static void Main()
    {
        // Simple if 
        int marks = 45;
        if (marks > 35)
        {
            System.Console.WriteLine("Congratualtions");
        }


        // if-else
        if (marks > 35)
        {
            System.Console.WriteLine("Congratualtions");
        }
        else
        {
            System.Console.WriteLine("Better luck next time");
        }

        // else-if
        char gradeLetter;
        if (marks >= 85)
        {
            gradeLetter = 'O';
        }
        else if (marks >= 60 && marks < 85)
        {
            gradeLetter = 'A';
        }
        else if (marks >= 50 && marks < 60)
        {
            gradeLetter = 'B';
        }
        else if (marks >= 35 && marks < 50)
        {
            gradeLetter = 'C';
        }
        else
        {
            gradeLetter = 'F';
        }
        System.Console.WriteLine("Your grade is " + gradeLetter);


        // Switch
        string gradeDescription;
        switch (gradeLetter)
        {
            case 'O':
                gradeDescription = "Outstanding";
                break;
            case 'A':
                gradeDescription = "Excellent";
                break;
            case 'B':
                gradeDescription = "Good";
                break;
            case 'C':
                gradeDescription = "Average";
                break;
            case 'F':
                gradeDescription = "Fail";
                break;
            default:
                gradeDescription = "None";
                break;
        }
        System.Console.WriteLine(gradeDescription);
        System.Console.ReadKey();
    }
}