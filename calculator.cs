using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Name: Your Name, Roll No: Your Roll Number");

        // Addition
        Console.WriteLine("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sum: " + (a + b));
    }
}
