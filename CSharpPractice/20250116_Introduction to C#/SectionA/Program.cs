using System;
class SectionA
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
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter your GPA: ");
        float gpa = float.Parse(Console.ReadLine());
        Console.WriteLine($"Name: {name}, Age: {age}, GPA: {gpa} ");
    }
    static void Program4()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        float division = (float)num1 / num2;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {division}");
    }
}