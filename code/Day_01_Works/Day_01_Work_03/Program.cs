class Sample
{
    // Variable and Data Type
    static void Main()
    {
        string studentName;
        studentName = "Raj";
        int age = 18;

        System.Console.WriteLine("Student Name: " + studentName);
        System.Console.WriteLine("Student Age: " + age);

        sbyte a = 100;
        sbyte b = sbyte.MinValue;
        sbyte c = sbyte.MaxValue;
        sbyte d = default(sbyte);
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        System.Console.WriteLine(c);
        System.Console.WriteLine(d);

        System.Console.WriteLine("DataType\tSize Default\tMinValue\t\tMaxValue");
        System.Console.WriteLine($"sbyte:\t\t{sizeof(sbyte)}\t{default(sbyte)}\t{sbyte.MinValue}\t\t\t{sbyte.MaxValue}");
        System.Console.WriteLine($"byte:\t\t{sizeof(byte)}\t{default(byte)}\t{byte.MinValue}\t\t\t{byte.MaxValue}");
        System.Console.WriteLine($"short:\t\t{sizeof(short)}\t{default(short)}\t{short.MinValue}\t\t\t{short.MaxValue}");
        System.Console.WriteLine($"ushort:\t\t{sizeof(ushort)}\t{default(ushort)}\t{ushort.MinValue}\t\t\t{ushort.MaxValue}");
        System.Console.WriteLine($"int:\t\t{sizeof(int)}\t{default(int)}\t{int.MinValue}\t\t{int.MaxValue}");
        System.Console.WriteLine($"uint:\t\t{sizeof(uint)}\t{default(uint)}\t{uint.MinValue}\t\t\t{uint.MaxValue}");
        System.Console.WriteLine($"long:\t\t{sizeof(long)}\t{default(long)}\t{long.MinValue}\t{uint.MaxValue}");
        System.Console.WriteLine($"ulong:\t\t{sizeof(ulong)}\t{default(ulong)}\t{ulong.MinValue}\t\t\t{uint.MaxValue}");
        System.Console.WriteLine($"ulong:\t\t{sizeof(ulong)}\t{default(ulong)}\t{ulong.MinValue}\t\t\t{uint.MaxValue}");
        System.Console.ReadKey();
    }
}