using System;

namespace BajajDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Bajaj Capital .NET 4.7 Demo!");
            
            // Deliberate SonarQube violation: hardcoded password
            string dbPassword = "SuperSecretPassword123!";
            Console.WriteLine("Connecting to DB...");
        }
    }
}
