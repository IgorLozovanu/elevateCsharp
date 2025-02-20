using DelegateBasicExemple;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateStaticMethod.Execute();
            DelegateInstanceMethod.Execute();
            MultiDelegate.Execute();
            DelegateAsParameter.Execute();

            Console.ReadKey();
        }
    }
}