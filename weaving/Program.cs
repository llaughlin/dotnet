
using System;
using Tracer.Log4Net;
using log4net.Config;

namespace WeavingSandbox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BasicConfigurator.Configure();

            Log.Info("Writing stuff");

            Console.WriteLine("Hello World");
        }
    }
}
