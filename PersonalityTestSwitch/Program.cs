using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite colour");
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "red":
                    Console.WriteLine("You are romantic");
                    break;
                case "blue":
                    Console.WriteLine("You are a workaholic");
                    break;
                case "green":
                    Console.WriteLine("You care about environment");
                    break;
                default:
                    Console.WriteLine($"You are a {userInput} unicorn!!!");
                    break;
            }
            Console.WriteLine("Have a nice day!!!");
        }
    }
}
