namespace DelegateBasicExemple
{
    class DelegateInstanceMethod
    {
        delegate void LogDel(string text); 

        public static void Execute()
        {
            // Instance method delegation
            Log log = new Log();
            LogDel logDel = new LogDel(log.LogTextToScreen);

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            logDel(name);
        }
    }

    class Log
    {
        public void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

        public void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }
    }
}
