using Models;
using System;

namespace CSharp.DesignPatterns.Behavioral.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CookingMethod cookMethod = new();

            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();
            cookMethod.Food = food;

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch(input)
            {
                case 1:
                    cookMethod.CookStrategy = new Grilling();
                    cookMethod.Cook();
                    break;

                case 2:
                    cookMethod.CookStrategy = new OvenBaking();
                    cookMethod.Cook();
                    break;

                case 3:
                    cookMethod.CookStrategy = new DeepFrying();
                    cookMethod.Cook();
                    break;

                default:
                    Console.WriteLine("invalid");
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}
