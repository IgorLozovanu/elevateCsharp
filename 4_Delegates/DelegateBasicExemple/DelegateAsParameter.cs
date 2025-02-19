using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBasicExemple
{
    class DelegateAsParameter
    {
        delegate void LogDel(string text);

        public static void Execute()
        {
            LogDel logTextToScreen = new LogDel(LogTextToScreen);

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            LogText(logTextToScreen, name);
        }

        static void LogText(LogDel logDel, string text)
        {
            logDel(text);
        }

        static void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

    }
}
