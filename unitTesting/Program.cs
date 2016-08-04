using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTesting.Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiply multiply = new Multiply();

            Console.WriteLine("Welcome to my crazy multiplying stuffs");

            while (true)
            {
                Console.WriteLine("What would you like to multiply");

                var answer1 = Console.ReadLine();
                var answer2 = Console.ReadLine();

                int one;
                int two;

                bool success1 = int.TryParse(answer1, out one);
                bool success2 = int.TryParse(answer2, out two);

                if (success1 && success2)
                {
                    Console.WriteLine(multiply.MultiplyIntegers(one, two).ToString());
                }

                Console.ReadKey();
            }
                
        }
    }
}
