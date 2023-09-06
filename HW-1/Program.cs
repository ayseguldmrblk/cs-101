using System;
using System.Transactions;

namespace cs101
{
    class Odev1
    {
        static void Part1()
        {
            Console.WriteLine("Enter a positive number: (You'll be asked to enter this number of numbers.)" );
            int number = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[number];
            int i = 0;
            do
            {
                Console.WriteLine("Enter the {0}. number: ", i + 1);
                int entry = Convert.ToInt32(Console.ReadLine());
                if (entry > 0)
                {
                    numbers[i] = entry;
                    i++;
                }
                else
                {
                    Console.WriteLine("Please enter a positive number!");
                }
            } while (i < number);
            Console.WriteLine("Even numbers in the array you've provided: ");
            foreach (int num in numbers)
            {
                if(num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void part2()
        {
            Console.WriteLine("Enter two numbers: (n and m, n is for the numbers you'll enter, m is for the number you'll divide the numbers you've entered.)");
            int n = 0, m = 0;
            bool validInput = false;

            do
            {
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                m = Convert.ToInt32(Console.ReadLine());
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers for n and m.");
            }
            } while (!validInput);
            int i = 0;
            do
            {
                Console.WriteLine("Enter the {0}. number: ", i + 1);
                int entry = Convert.ToInt32(Console.ReadLine());
                if(entry % m == 0)
                {
                    Console.WriteLine("Divisible by m: " + entry);
                }
                else 
                {
                    Console.WriteLine("Not divisible by m: " + entry);
                }
                i++;
            } while (i < n);
        }

        static void Part3()
        {
            bool validInput = false;
            int number = 0;
            do
            {
                try
                {
                    Console.WriteLine("Enter a number: (You'll be asked to enter this number of strings.)");
                    number = Convert.ToInt32(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            } while (!validInput);

            string[] words = new string[number];
            int i = 0;
            do
            {
                Console.WriteLine("Enter a string: ");
                string entry = Console.ReadLine();
                words[i] = entry;
                i++;
            } while (i < number);
            Console.WriteLine("The strings you've entered in reverse order: ");
            for (int j = number - 1; j >= 0; j--) 
            {
                Console.WriteLine(words[j]);
            }
        }

        static void Part4()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine("The number of words in this sentence: {0}", words.Length);
            Console.Write("The number of characaters in this sentence: ");
            Console.WriteLine(sentence.Length); 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**************Part 1**************");
            Part1();
            Console.WriteLine("**************Part 2**************");
            part2();
            Console.WriteLine("**************Part 3**************");
            Part3();
            Console.WriteLine("**************Part 4**************");
            Part4();
        }
    }
}   
