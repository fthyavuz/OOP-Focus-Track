// See https://aka.ms/new-console-template for more information
using System;
using System.Linq.Expressions;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args);
            // function definition to calculate the square of the entered number
            static int calSquare(string userInput)
            {
                // check user input is valid
                try
                {
                    int num = Int32.Parse(userInput);
                    return num * num;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    return -1;
                }

            }

            // Ask to user for input
            Console.WriteLine("Enter a number:");

            // Create a string variable to get user input from the keyboard
            string userInput = Console.ReadLine() ?? string.Empty;

            int responseMethod = calSquare(userInput); 

            while(responseMethod == -1)
            {
                Console.WriteLine("Enter a number:");
                userInput = Console.ReadLine();
                responseMethod = calSquare(userInput);


            }
            Console.WriteLine($"The square of {userInput} is {calSquare(userInput)}");

        }
    }
}
