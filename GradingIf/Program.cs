using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your test result");
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper());

            if(userInput == 'A')
            {
                Console.WriteLine("Outstanding");
            }
            else if(userInput == 'B')
            {
                Console.WriteLine("Superior");
            }
            else if(userInput == 'C')
            {
                Console.WriteLine("Good");
            }
            else if(userInput == 'D')
            {
                Console.WriteLine("Satisfactory");
            }
            else if(userInput == 'E')
            {
                Console.WriteLine("Low Pass");
            }
            else if(userInput == 'F')
            {
                Console.WriteLine("Failure");
            }
        }
    }
}
