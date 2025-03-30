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
    }

    static void program1()
    {
        int count = 0;
        while (count <= 10)
        {
            Console.WriteLine($"Count: {count}");
            count++;
        }
    }

    static void program2()
    {
        int count = 1;
        do
        {
            Console.WriteLine($"Count: {count}");
            count++;
        } while (count <= 5);
    }

    static void program3()
    {
        int number;
        Console.Write("Enter a number greater than 0: ");
        number = int.Parse(Console.ReadLine());
        while (number > 0)
        {
            Console.WriteLine($"Current value: {number}");
            number--;
        }
    }


    static void program4()
    {
        int number;
        Console.Write("Enter a number greater than 0: ");
        number = int.Parse(Console.ReadLine());
        while (number >= 0)
        {
            Console.WriteLine($"Current value: {number}");
            number--;
        }
    }

    static void program5()
    {
        int counter = 1;
        do
        {
            Console.WriteLine($"Counter: {counter} ");
            counter++;
        } while (counter <= 5);
    }

    static void program6()
    {
        int counter = 1;
        do
        {
            Console.WriteLine($"Counter: {counter} ");
            counter++;
        } while (counter < 5);
    }


    static void program7()
    {
        int option;
        do
        {
            Console.WriteLine("1. Continue");
            Console.WriteLine("2. Exit");
            Console.Write("Enter choice: ");
            option = int.Parse(Console.ReadLine());
        } while (option != 2);
    }

    static void program8()
    {
        int option;
        do
        {
            Console.WriteLine("1. Continue");
            Console.WriteLine("2. Exit");
            Console.Write("Enter choice: ");
            option = int.Parse(Console.ReadLine());

            if ((option != 1 && option != 2))
            {
                Console.WriteLine("sorry?");
            }
            Console.WriteLine("-----");
        } while (option != 2);
    }
}