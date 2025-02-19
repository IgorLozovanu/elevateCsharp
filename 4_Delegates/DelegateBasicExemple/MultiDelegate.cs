namespace Delegate
{
    class MultiDelegate
    {
        delegate void LogDel(string text);

        public static void Execute()
        {
            // Multicast delegate
            Log log = new Log();

            LogDel LogTextToScreenDel = new LogDel(log.LogTextToScreen);
            LogDel LogTextToFileDel = new LogDel(log.LogTextToFile);
            LogDel multilogDel = LogTextToScreenDel + LogTextToFileDel;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            multilogDel(name);

            Console.ReadKey();
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
