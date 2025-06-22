using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Singleton Pattern:");

            Logger logger1 = Logger.Instance;
            logger1.Log("1st log message.");

            Logger logger2 = Logger.Instance;
            logger2.Log("2nd log message.");

            
            if (object.ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine("Both logger instances are the same.");
            }
            else
            {
                Console.WriteLine("Logger instances are different");
            }

            Console.ReadLine();
        }
    }
}
