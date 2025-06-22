using System;

namespace SingletonPatternExample
{
    public class Logger
    {
     
        private static readonly Logger _instance = new Logger();

       
        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

    
        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

    
        public void Log(string message)
        {
            Console.WriteLine($"Log Entry: {message}");
        }
    }
}
