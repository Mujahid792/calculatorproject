using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Name: Your Name, Roll No: Your Roll Number");

        // Division
        Console.WriteLine("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (b == 0)
            Console.WriteLine("Cannot divide by zero.");
        else
            Console.WriteLine("Quotient: " + (a / b));
    }
}
