<h1><h1><h1>Calculator Program in C# </h1>
This program creates a calculator that performs basic arithmetic operations (addition, subtraction, multiplication, and division) on two numbers entered by the user.

<h1><h1>How to Run</h1>
1. Install .NET Core if you don't have it already. <br>
2. Copy the code from Calculator.cs into a new file in a C# project.

<h1>Build and run the program.
Code Explanation</h1>
The program starts by declaring three variables: num1, num2, and result, all of type double. It also declares a char variable named operation to hold the arithmetic operation entered by the user.

```bash 
double num1, num2, result;
char operation;
```
The program then prompts the user to enter the first number, reads in the input using Console.ReadLine(), and converts it to a double using double.Parse().
```bash
Console.WriteLine("Enter the first number:");
num1 = double.Parse(Console.ReadLine());
```
The same process is repeated for the second number and the operation.
```bash
Console.WriteLine("Enter the second number:");
num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the operation (+, -, *, /):");
operation = char.Parse(Console.ReadLine());
```
A switch statement is used to perform the specified operation and display the result. If the operation is division (/), the program checks if the second number is zero to avoid a division by zero error.

```bash 
switch (operation)
{
    case '+':
        result = num1 + num2;
        Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
        break;

    case '-':
        result = num1 - num2;
        Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
        break;

    case '*':
        result = num1 * num2;
        Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
        break;

    case '/':
        if (num2 != 0)
        {
            result = num1 / num2;
            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        break;

    default:
        Console.WriteLine("Invalid operation.");
        break;
}
```


<h1> License </h1>

This calculator program is open-source .
