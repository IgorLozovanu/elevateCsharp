namespace Delegate
{
    class Program
    {
        /*
         * Delegate = a variable that reference a method
         */

        // This delegate can reference methods with a parameter and no return
        // Is possible to extend its accessibility declaring it out from the class
        delegate void LogDel(string text);

        static void Main(string[] args)
        {
            // Static method delegation

            // LogDel logDel = new LogDel(LogTextToScreen); 
            // LogDel logDel = new LogDel(LogTextToFile);

            // Instance method delegation

            Log log = new Log();
            LogDel logDel = new LogDel(log.LogTextToFile);

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Multicast delegate
            LogDel LogTextToScreen

            // Alternative way to invoke the referenced method
            // logDel.Invoke("text");
            logDel(name);

            Console.ReadKey();
        }

        // Is possible to delegate static methods 

        // static void LogTextToScreen(string text)
        // {
        //     Console.WriteLine($"{DateTime.Now}: {text}");
        // }

        // static void LogTextToFile(string text)
        // {
        //     using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
        //     {
        //         sw.WriteLine($"{DateTime.Now}: {text}");
        //     }
        // }
    }

    // Is possible to delegate also instance methods 
    public class Log
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