namespace Color
{
    public static class BackgroundColor
    {
        public static string GetTextFullLine(string text)
        {
            var x = System.Console.WindowWidth;
            return text.PadRight(System.Console.WindowWidth, ' ');
        }

        public static void ColorFullPage(System.ConsoleColor backgroundColor, System.ConsoleColor textColor)
        {
            System.Console.ForegroundColor = textColor;
            System.Console.BackgroundColor = backgroundColor;
            System.Console.Clear();
        }
    }
}
