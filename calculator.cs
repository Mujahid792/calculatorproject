using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Name: Your Name, Roll No: Your Roll Number");

        // Multiplication
        Console.WriteLine("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Product: " + (a * b));
    }
}
