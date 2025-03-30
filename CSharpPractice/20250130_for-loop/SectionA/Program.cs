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
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }
    }
    static void program2()
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is even");
            }
            else
            {
                Console.WriteLine($"{i} is odd");
            }
        }
    }
    static void program3()
    {
        Console.Write("Enter the number of iterations: ");
        int iterations = int.Parse(Console.ReadLine());

        for (int i = 1; i <= iterations; i++)
        {
            Console.WriteLine($"iteration: {i}");
        }
    }
    static void program4()
    {
        Console.Write("enter a number to check if it is prime: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime && number > 1)
        {
            Console.WriteLine($"{number} is a prime number");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number");
        }
    }
    static void program5()
    {
        int counter = 1;
        while (counter <= 5)
        {
            Console.WriteLine($"Counter: {counter}");
            counter++;
        }
    }
    static void program6()
    {
        string input;
        while (true)
        {
            Console.Write("Enter a word (or type 'exit' to quit): ");
            input = Console.ReadLine();
            if (input.ToLower() == "exit" || input == "")
            {
                Console.WriteLine("Bye!");
                break;
            }
            Console.WriteLine($"You entered: {input}");
        }
    }
    static void program7()
    {
        int counter = 8;
        do
        {
            Console.WriteLine($"Counter: {counter}");
            counter--;
        } while (counter >= 5);
    }
    static void program8()
    {
        int choice;

        do
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                case 2:
                    Console.WriteLine($"You selected Option {choice}.");
                    break;
                case 3:
                    Console.WriteLine("Thank you for using our service!");
                    break;
                default:
                    Console.WriteLine($"{choice} is invalid. Try again");
                    break;
            }
            Console.WriteLine("-----");
        } while (choice != 3);
    }
}