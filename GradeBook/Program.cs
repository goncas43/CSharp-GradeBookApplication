using System;
using GradeBook.UserInterfaces;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#=======================#");
            Console.WriteLine("# Welcome to GradeBook! #");
            Console.WriteLine("#=======================#");
            Console.WriteLine();

            StartingUserInterface.CommandLoop();

            Console.WriteLine("Thank you for using GradeBook!");
            Environment.Exit(0);
        }
    }
}