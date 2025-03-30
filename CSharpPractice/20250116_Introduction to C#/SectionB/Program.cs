using System;
class SectionB
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Program1 ---");
        Program1();
        Console.WriteLine("--- Program2 ---");
        Program2();
        Console.WriteLine("--- Program3 ---");
        Program3();
        Console.WriteLine("--- Program4 ---");
        Program4();
        Console.WriteLine("--- Program5 ---");
        Program5();
        Console.WriteLine("--- Program6 ---");
        Program6();
        Console.WriteLine("--- Program7 ---");
        Program7();
    }
    static void Program1()
    {
        Console.WriteLine("Hello, World!");
    }
    static void Program2()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
    }
    static void Program3()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sum: {num1 + num2}");
        Console.WriteLine($"Difference: {num1 - num2}");
        Console.WriteLine($"Product: {num1 * num2}");
        Console.WriteLine($"Quotient: {(float)num1 / num2}");
    }
    static void Program4()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine()); // Fill in to take age input
        int futureAge = age + 5; // Calculate age in 5 years
        Console.WriteLine($"In 5 years, you will be {futureAge} years old.");
    }
    static void Program5()
    {
        int number = 10;
        float price = 19.99f;
        string message = "C# is fun!";
        bool isLearning = true;
        Console.WriteLine($"Integer: {number}");
        Console.WriteLine($"Float: {price}");
        Console.WriteLine($"String: {message}");
        Console.WriteLine($"Boolean: {isLearning}");
    }
    static void Program6()
    {
        Console.Write("Enter the length: ");
        int length = int.Parse(Console.ReadLine()); // Fill in to take length input
        Console.Write("Enter the width: ");
        int width = int.Parse(Console.ReadLine()); // Fill in to take width input
        int area = length * width; // Calculate area
        Console.WriteLine($"The area of the rectangle is {area}.");
    }
    static void Program7()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0) // Check if number is positive
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0) // Check if number is negative
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
