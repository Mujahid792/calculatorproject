using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Name: Your Name, Roll No: Your Roll Number");

 substraction
 multiplication
 division
        // Division

        // Multiplication
multiplication

        // Subtraction
substraction

        // Addition
 addition
        Console.WriteLine("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
 substraction
 multiplication
division
        if (b == 0)
            Console.WriteLine("Cannot divide by zero.");
        else
            Console.WriteLine("Quotient: " + (a / b));

        Console.WriteLine("Product: " + (a * b));
 multiplication

        Console.WriteLine("Difference: " + (a - b));
 substraction

        Console.WriteLine("Sum: " + (a + b));
 addition
 conflict-branch2
     Console.WriteLine("Hello from conflict branch 2!");
     Console.WriteLine("Hello from conflict branch 1!");
 main

    }
}
