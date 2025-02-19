using DelegateBasicExemple;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiDelegate.Execute();
            DelegateAsParameter.Execute();

            Console.ReadKey();
        }
    }
}