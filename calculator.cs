using System;

class Calculator
{
    static void Main()
    {
        double num1, num2, result;
        char operation;

        Console.WriteLine("Calculator Program");
        Console.WriteLine("------------------");

        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
                break;
            default:
                Console.WriteLine("Invalid operation!");
                break;
        }

        Console.ReadLine();
    }
}
