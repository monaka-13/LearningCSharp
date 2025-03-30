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
        Console.WriteLine("--- Program6 ---");
        program6();
        Console.WriteLine("--- Program7 ---");
        program7();
        Console.WriteLine("--- Program8 ---");
        program8();
        Console.WriteLine("--- Program9 ---");
        program9();
        Console.WriteLine("--- Program10 ---");
        program10();
    }

    static void program1()
    {
        int numberDeclaration = 100;
        string stringDeclaration = "String";
        float floatDeclaration = 1.1f;
        bool boolDeclaration = true;
        Console.WriteLine($"Int: {numberDeclaration}");
        Console.WriteLine($"String: {stringDeclaration}");
        Console.WriteLine($"Float: {floatDeclaration}");
        Console.WriteLine($"Bool: {boolDeclaration}");
    }
    static void program2()
    {
        Console.WriteLine("Input Name");
        string name = Console.ReadLine();
        Console.WriteLine("Input Age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Input GPA");
        float gpa = float.Parse(Console.ReadLine());
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"GPA: {gpa}");
    }
    static void program3()
    {
        Console.WriteLine("Input first number");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second number");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
    }
    static void program4()
    {
        Console.WriteLine("Input number");
        int num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            Console.WriteLine($"Number you typed is positive");
        }
        else if (num < 0)
        {
            Console.WriteLine($"Number you typed is negative");
        }
        else
        {
            Console.WriteLine($"Number you typed is zero or something like that");
        }
    }
    static void program5()
    {
        Console.WriteLine("Input first number");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input second number");
        int num2 = int.Parse(Console.ReadLine());
        if (num1 > num2)
        {
            Console.WriteLine($"first number is grater than second number");
        }
        else if (num1 < num2)
        {
            Console.WriteLine($"first number is less than second number");
        }
        else
        {
            Console.WriteLine($"Numbers are equal");
        }
    }
    static void program6()
    {
        Console.WriteLine("Input your age");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18)
        {
            Console.WriteLine($"You are eligible to vote");
        }
        else
        {
            Console.WriteLine($"You are NOT eligible to vote");
        }
    }
    static void program7()
    {
        Console.WriteLine("Input length");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Input width");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine($"The area of rectangle is {length * width}.");
    }
    static void program8()
    {
        Console.Write(" Enter a grade (A, B, C, D, F): ");
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
    static void program9()
    {
        Console.WriteLine("Input first number");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Input second number");
        float num2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Input third number");
        float num3 = float.Parse(Console.ReadLine());
        Console.WriteLine($"The average is {(num1 + num2 + num3) / 3}.");
    }
    static void program10()
    {
        Console.WriteLine("Input your age");
        int age = int.Parse(Console.ReadLine());
        if (!(age >= 0 && age <= 150))
        {
            Console.WriteLine("Ridiculous. Try again.");
        }
        else
        {
            Console.WriteLine("Got it!");
        }
    }
}