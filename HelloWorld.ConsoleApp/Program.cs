using System;
using HelloWorld.Library2;

namespace HelloWorld.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Class2.SubtractThenAdd(1, 2, 3);
            Console.WriteLine("I ran a basic function from a .NET standard library and the output was " + a.ToString());
            Console.WriteLine("Press any key to exit out of the program.");
            Console.ReadLine();
        }
    }
}