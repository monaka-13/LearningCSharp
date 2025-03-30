using System;
class SectionB
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

    // 1. Write a program to print numbers from 1 to 100 using a for loop.
    static void program1()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    // 2. Write a program to print all even numbers between 1 and 50 using a for loop.
    static void program2()
    {
        for (int i = 2; i <= 50; i = i + 2)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    // 3. Write a program to calculate the sum of the first 20 natural numbers using a for loop.
    static void program3()
    {
        int added = 0;
        for (int add = 1; add <= 20; add++)
        {
            added = added + add;
        }
        Console.WriteLine($"calculation the sum of the first 20 natural numbers is {added}");
    }

    // 4. Write a program that asks the user to input a number and prints its mujltiplication table using a for loop.

    static void program4()
    {
        Console.WriteLine("input number");
        int keyNum = int.Parse(Console.ReadLine());
        for (int i = 1; i <= keyNum; i++)
        {
            for (int j = 1; j <= keyNum; j++)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }
        }
    }

    // 5. Write a program to take a number from the user and check whether it is a prime number using a for loop.
    static void program5()
    {
        Console.WriteLine("input number");
        int keyNum = int.Parse(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i <= keyNum - 1; i++)
        {
            if (keyNum % i == 0)
            {
                Console.WriteLine($"{keyNum} is not prime");
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine($"{keyNum} is prime");
        }
    }

    // 6. Write a program to print numbers from 1 to 10 using a while loop.
    static void program6()
    {
        int i = 1;
        while (i <= 10)
        {
            Console.Write($"{i} ");
            i++;
        }
        Console.WriteLine();
    }

    // 7. Write a program that continuously asks the user for input until they enter -1 using a while loop.

    static void program7()
    {
        Console.WriteLine("type it");
        String str = Console.ReadLine();
        while (str != "-1")
        {
            Console.WriteLine("type it");
            str = Console.ReadLine();
        }
        Console.WriteLine("fin");
    }

    // 8. Write a program to calculate the factorial of a number provided by the user using a while loop.
    // e.g. 1->1, 2->2, 3->6, 4->24, 5->120
    static void program8()
    {
        Console.WriteLine("type number");
        int times = int.Parse(Console.ReadLine());
        int count = 1;
        int cal = 1;
        while (count <= times)
        {
            cal = cal * count;
            count++;
        }
        Console.WriteLine($"calculation the factorial of a number provided by the user using is {cal}");
    }

    // 9. Write a program to display a menu (with options like Option 1, Option 2, Exit) repeatedly using a do-while loop. Exit the loop when the user selects Exit.
    static void program9()
    {
        int order = -1;
        do
        {
            Console.WriteLine("What can I help you?");
            Console.WriteLine("1: Compile Error");
            Console.WriteLine("2: Exception");
            Console.WriteLine("3: Other");
            Console.WriteLine("0: Exit");
            order = int.Parse(Console.ReadLine());
            Console.WriteLine("I can't help you. Do your best!");
            Console.WriteLine("-----");
        } while (order != 0);
        Console.WriteLine("Thank you using our service. You are smarter than asking someone, aren't you?");
    }

    // 10. Write a guessing game program where the computer generates a random number between 1 and 100, and the user must guess it. Use a do-while loop to keep prompting the user until they guess correctly.
    static void program10()
    {
        Random rnd = new Random();
        int ans = rnd.Next(1, 10);
        int atmp = 0;
        Console.WriteLine("GuessGame");
        do
        {
            Console.WriteLine("Guess the answer between 1 to 100");
            atmp = int.Parse(Console.ReadLine());
        } while (atmp != ans);
        Console.WriteLine("Awesome!");
    }
}