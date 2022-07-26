using System;
using System.Collections.Generic;

namespace ListChecker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //  Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
            //  If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            //  otherwise, display the 3 smallest numbers in the list.

            Console.WriteLine("Please enter a list of 5 comma seperated numbers");

            var userInput = Console.ReadLine();
            userInput = userInput.Replace(",", String.Empty);
            List<int> Input = new List<int>();

            for (var i = 0; i < userInput.Length; i++)
            {
                Input.Add(userInput[i]);
                Console.WriteLine(userInput[i]);
            };

            Console.WriteLine(Input);
            
        }
    }
}
