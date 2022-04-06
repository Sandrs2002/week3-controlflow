using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite colour");
            string userInput = Console.ReadLine().ToLower();

            if(userInput == "red")
            {
                Console.WriteLine("You are very romantic");
            }
            else if(userInput == "blue")
            {
                Console.WriteLine("You are a workaholic");
            }
            else if(userInput == "green")
            {
                Console.WriteLine("You care about environment");
            }
            else
            {
                Console.WriteLine($"You are a {userInput} unicorn!!!!");
            }
            Console.WriteLine("Have a nice day!!!!!!!");
        }
    }
}
