using System;
using System.IO;
using HelloWorld.Library2;

namespace HelloWorld.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Class2.SubtractThenAdd(1, 2, 3);
            Console.WriteLine("I ran a basic function from a .NET standard library and the output was " + a.ToString());
            ReadFile();
        }

        public static void ReadFile()
        {
            string assemblyDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string textPath = Path.Combine(assemblyDir, "AppData");
            textPath = Path.Combine(textPath, "SampleText.txt");
            if(File.Exists(textPath))
            {
                Console.WriteLine("Found the text file:");
            }
            else
            {
                Console.WriteLine("Didn't find the file:");
            }
            Console.WriteLine("Path used: " + textPath);
        }
    }
}