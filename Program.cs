using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            var firstInput = Console.ReadLine();
            bool firstResult = int.TryParse(firstInput, out int first);

            if (!firstResult)
            {
                Console.WriteLine($"You entered '{firstInput}' which is not a valid integer");
                return;
            }

            Console.Write("Enter second number: ");
            var secondInput = Console.ReadLine();
            bool secondResult = int.TryParse(secondInput, out int second);

            if (!secondResult)
            {
                Console.WriteLine($"You entered '{secondInput}' which is not a valid integer");
                return;
            }
            if (first == second)
            {
                Console.WriteLine($"integers you have entered are equal, please enter different integers so we can compare");
                return;
            }

            int bigger = (first > second) ? first : second;
            if (bigger == 0)
            {
                Console.WriteLine($"bigger number is {bigger} wich can be positive or negative and even or odd");
                return;
            }
            bool isEven = bigger % 2 == 0;
            string oddEven = isEven ? "even" : "odd";
            bool isPoitive = bigger > 0;
            string posNeg = isPoitive ? "positive" : "negative";
            Console.WriteLine($"Between {first} and {second} the bigger one is {bigger}, which is an {oddEven} number and {posNeg} number");


            // Task 2: 

            Console.WriteLine("Enter number from 1 to 3");
            string input = Console.ReadLine();

            bool checkIfCanParse = int.TryParse(input, out int result);

            if (!checkIfCanParse)
            {
                Console.WriteLine($"you entered '{input}' wich is not valid integer");
            }

            switch (result)
            {
                case 1:
                    Console.WriteLine("You got new car!");
                    break;
                case 2:
                    Console.WriteLine("You got new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got new bike!");
                    break;
                default:
                    Console.WriteLine("You have entered wrong integer you need to enter integer between 1 and 3 please try again");
                    break;
            }
        
    }
    }
}
