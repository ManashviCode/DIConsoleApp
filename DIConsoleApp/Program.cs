using System;
using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace DIConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ServiceCollection =new ServiceCollection();
            ServiceCollection.AddScoped< RandomGuidGenerator>();//only one instance is passed for every request

            var provider = ServiceCollection.BuildServiceProvider();

            var obj1=provider.GetService<RandomGuidGenerator>();
            var obj2=provider.GetService<RandomGuidGenerator>();

      
            Console.WriteLine($"Random 1 - {obj1.Generate}");
            Console.WriteLine($"Random 2 - {obj2.Generate}");

            //there are three types of Service Lifetimes in IoC Containers
            //using registering services in an IoC container methods, can easy to define how instances of those services are created and managed throughout the application's lifecycle.
            /*
            ServiceCollection.AddSingleton();//One instance for the entire application
            ServiceCollection.AddScoped(); //One instance per request
            ServiceCollection.AddTransient();//A new instance each time it’s requested.
            */


        }
    }
}

