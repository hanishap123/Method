// Author: Hanisha Pagarani
// Date: 02/04/2021
// Comment: This C# application demonstrates the use of methods after getting input from a user
using System;

namespace Method
{
    class Program
    {
        // void method
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            
            // asks the user to input a name
            Console.WriteLine("Hello " +  name);
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);

        }
    }
}
