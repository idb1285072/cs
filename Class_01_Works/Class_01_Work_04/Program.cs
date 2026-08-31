class Sample
{
    static void Main()
    {
        /*
        datatype:
            - primitive types: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal, char, bool
            - Non-primitive types: string, object, class, interface, array, delegate, enum
        */
        System.Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue} - {default(sbyte)} {sizeof(sbyte)}");
        System.Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue} - {default(byte)} {sizeof(byte)}");
        System.Console.WriteLine($"short: {short.MinValue} to {short.MaxValue} - {default(short)} {sizeof(short)}");
        System.Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue} - {default(ushort)} {sizeof(ushort)}");
        System.Console.WriteLine($"int: {int.MinValue} to {int.MaxValue} - {default(int)} {sizeof(int)}");
        System.Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue} - {default(uint)} {sizeof(uint)}");
        System.Console.WriteLine($"long: {long.MinValue} to {long.MaxValue} - {default(long)} {sizeof(long)}");
        System.Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue} - {default(ulong)} {sizeof(ulong)}");
        System.Console.WriteLine($"float: {float.MinValue} to {float.MaxValue} - {default(float)} {sizeof(float)}");
        System.Console.WriteLine($"double: {double.MinValue} to {double.MaxValue} - {default(double)} {sizeof(double)}");
        System.Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} - {default(decimal)} {sizeof(decimal)}");
        System.Console.WriteLine($"char: {char.MinValue} to {char.MaxValue} - {default(char)} {sizeof(char)}");
        System.Console.WriteLine($"bool: {false} to {true} - {default(bool)} {sizeof(bool)}");
        System.Console.WriteLine($"string: {default(string)}");
        System.Console.WriteLine($"object: {default}");

        System.Console.ReadKey();
    }
}