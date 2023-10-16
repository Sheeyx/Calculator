using System;


namespace Calculator
{
    class Program
    {
        static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("1. Add two Numbers");
                Console.WriteLine("2. Add list of Numbers");
                Console.WriteLine("3. Exit");
                Console.Write("Choose your option: ");
                string choice = Console.ReadLine();

                void AddTwoNum()
                {
                    Console.Write("Enter first num: ");
                    decimal num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter second num: ");
                    decimal num2 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Result: {num1 + num2}");
                }

                void AddListNum()
                {
                    Console.Write("Enter a list of numbers: ");
                    decimal[] numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(Convert.ToDecimal)
                    .ToArray();
                    decimal result = 0;
                    foreach (decimal number in numbers)
                    {
                       result += number;
                    }
                    Console.WriteLine($"Result: {result}");
                }

                switch (choice)
                {
                    case "1":
                        AddTwoNum();
                        break;
                    case "2":
                        AddListNum();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}

