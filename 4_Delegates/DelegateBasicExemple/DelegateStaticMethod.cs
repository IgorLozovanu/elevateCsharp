namespace DelegateBasicExemple
{
    class DelegateStaticMethod
    {
        delegate void LogDel(string text);
        public static void Execute()
        {
            // Static method delegation
            LogDel logDel = new LogDel(LogTextToScreen);

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            logDel(name);
        }

        static void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

    }
}
