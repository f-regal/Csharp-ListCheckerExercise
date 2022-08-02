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

            string[] inputs;
            while (true)
            {
                Console.WriteLine("Please enter a list of 5 comma seperated numbers");
                var userInput = Console.ReadLine();
               
                if (!String.IsNullOrEmpty(userInput))
                {
                    inputs = userInput.Split(',');
                    if (inputs.Length >= 5)
                    {
                        break;
                    }
                }

                Console.WriteLine("Invalid Please Try Again");
            }

            var numbers = new List<int>();
            foreach (string input in inputs)
            {
                numbers.Add(Convert.ToInt32(input));
            }

            var smallest = new List<int>();
            while (smallest.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallest.Add(min);

                numbers.Remove(min);
            }

            foreach (var num in smallest)
            {
                Console.WriteLine(num);
            }
        }
    }
}
