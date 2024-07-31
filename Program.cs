using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculator");
                Console.WriteLine("-----------------");

                double num1 = 0;
                double num2 = 0;
                char op = ' ';
                bool validInput = false;

                while (!validInput)
                {
                    Console.Write("Enter the first number: ");
                    try
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        validInput = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                    }
                }

                validInput = false;

                while (!validInput)
                {
                    Console.Write("Enter the second number: ");
                    try
                    {
                        num2 = Convert.ToDouble(Console.ReadLine());
                        validInput = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                    }
                }

                validInput = false;

                while (!validInput)
                {
                    Console.Write("Enter an operator (+, -, *, /): ");
                    try
                    {
                        op = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (op == '+' || op == '-' || op == '*' || op == '/')
                        {
                            validInput = true;
                        }
                        else
                        {
                            throw new FormatException();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Invalid operator. Please enter one of the following operators: +, -, *, /.");
                    }
                }

                double result = 0;
                bool validOperation = true;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            validOperation = false;
                        }
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
                    Console.WriteLine();
                }

                validInput = false;
                char ans = ' ';
                bool breakLoop = false;

                while (!validInput)
                {
                    Console.Write("Do you want to do another calculation? (Y/N): ");
                    try
                    {
                        ans = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (ans == 'Y' || ans == 'y')
                        {
                            validInput = true;
                        }
                        else if (ans == 'N' || ans == 'n')
                        {
                            validInput = true;
                            breakLoop = true;
                        }
                        else
                        {
                            throw new FormatException();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Invalid answer. Please enter either (Y/N) or (y/n)");
                    }
                }

                if (breakLoop)
                {
                    break;
                }

            }
        }
    }
}
