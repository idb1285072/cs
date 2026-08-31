class Operator
{
    static void Main()
    {
        decimal a = 10M;
        decimal b = 3M;

        // Arithmetic Operators
        System.Console.WriteLine(a + b);
        System.Console.WriteLine(a - b);
        System.Console.WriteLine(a * b);
        System.Console.WriteLine(a / b);
        System.Console.WriteLine(a % b);

        // Assignment Operators
        decimal c;
        c = a;
        System.Console.WriteLine(c);
        c += a;
        System.Console.WriteLine(c);
        c -= a;
        System.Console.WriteLine(c);
        c *= a;
        System.Console.WriteLine(c);
        c /= a;
        System.Console.WriteLine(c);
        c %= b;
        System.Console.WriteLine(c);

        // Increment / Decrement Operators
        decimal d = 10;
        System.Console.WriteLine(d++);
        System.Console.WriteLine(++d);
        System.Console.WriteLine(d);
        System.Console.WriteLine(d--);
        System.Console.WriteLine(--d);
        System.Console.WriteLine(d);

        // Comparision Operators
        System.Console.WriteLine(a == b);
        System.Console.WriteLine(a != b);
        System.Console.WriteLine(a < b);
        System.Console.WriteLine(a <= b);
        System.Console.WriteLine(a > b);
        System.Console.WriteLine(a >= b);

        // Logical Operators
        System.Console.WriteLine(a == 10 & b == 10);
        System.Console.WriteLine(a == 10 && b == 10);
        System.Console.WriteLine(a == 10 | b == 10);
        System.Console.WriteLine(a == 10 || b == 10);
        System.Console.WriteLine(a == 10 ^ b == 10);
        System.Console.WriteLine(!(a == 10));

        // Concatenation Operators
        string name = "Raj";
        int age = 10;
        string message = "Hey " + name + ", your age is " + age + ".";
        System.Console.WriteLine(message);

        // Ternary Operators
        string title = (age < 13) ? "Child" : (age > 13 && age <= 19) ? "Teenage" : "Adult";
        System.Console.WriteLine(title);

        // Opeartor Precedence
        double result = 10 + 4 * 30 / 10;
        System.Console.WriteLine(result);
        System.Console.WriteLine();
    }
}