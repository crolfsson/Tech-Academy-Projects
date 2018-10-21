using System;
using System.Threading;

namespace Acme_Accounting_Exercise
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Acme Accounting Systems");
            Thread.Sleep(1000);
            Console.WriteLine("Remember, we're \"accounting\" on you!");
            Console.ReadLine();
        }
    }
}
