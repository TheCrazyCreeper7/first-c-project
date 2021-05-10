using System;

namespace first_c__project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "c# project";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;
            Console.WriteLine("hello, i am your PC. what your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("hello " + userName + ",\nmy name is RX-9000");
            Console.WriteLine("where are you from?");
            string userL = Console.ReadLine();
            Console.WriteLine("no way! " + userL + " is my favorite place");
            Console.WriteLine("if you want you can prase enter to close me");
            Console.ReadKey();
        }
    }
}