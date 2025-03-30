using System;
class SectionA
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Program1 ---");
        program1();
        Console.WriteLine("--- Program2 ---");
        program2();
        Console.WriteLine("--- Program3 ---");
        program3();
        Console.WriteLine("--- Program4 ---");
        program4();
        Console.WriteLine("--- Program5 ---");
        program5();
    }

    static void program1()
    {
        string name = "Alice"; // String variable
        int age = 25; // Integer variable
        float height = 5.7f; // Floating - point variable
        bool isStudent = true; // Boolean variable
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Is a student: {isStudent}");
    }
    static void program2()
    {
        int num1 = 15;
        int num2 = 4;
        Console.WriteLine($"Addition: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");
        Console.WriteLine($"Division: {num1 / num2}");
        Console.WriteLine($"Modulus: {num1 % num2}");
    }
    static void program3()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

    }
    static void program4()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18 && age <= 25)
        {
            Console.WriteLine("You are a young adult.");
        }
        else if (age > 25)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are underage.");
        }
    }
    static void program5()
    {
        Console.Write("Enter a grade (A, B, C, D, F): ");
        char grade = char.Parse(Console.ReadLine().ToUpper()
        );
        if (grade == 'A')
        {
            Console.WriteLine("Excellent!");
        }
        else if (grade == 'B')
        {
            Console.WriteLine("Good job.");
        }
        else if (grade == 'C')
        {
            Console.WriteLine("Fair effort.");
        }
        else if (grade == 'D')
        {
            Console.WriteLine("Needs improvement.");
        }
        else if (grade == 'F')
        {
            Console.WriteLine("Fail.");
        }
        else
        {
            Console.WriteLine("Invalid grade.");
        }
    }
}
