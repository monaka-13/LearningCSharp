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

    // 1. Check if a number is a palindrome using a while loop. A palin-drome is a number that remains the same when reversed (e.g., 121, 1331).
    static void program1()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int original = num, rev = 0;

        while (num != 0)
        {
            int digit = num % 10;
            rev = rev * 10 + digit;
            num = (num - digit) / 10;
        }

        if (original == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not a palindrome");
    }

    // 2. Find the sum of all even digits in a number using a while loop. The program should extract each digit from a number and sum only the even ones.
    // (e.g. 26->8, 1234567->12)
    static void program2()
    {
        Console.Write(" Enter a number : ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        while (num != 0)
        {
            int digit = num % 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }
            num = (num - digit) / 10;
        }
        Console.WriteLine($"Sum of even digits : {sum}");
    }

    // 3. Generate prime numbers up to a given limit using a while loop. The program should take user input and print all prime numbers up to that limit.
    // (e.g. 4->2,3,  7->2,3,5,7)
    static void program3()
    {
        Console.Write(" Enter the limit : ");
        int limit = int.Parse(Console.ReadLine());
        int num = 2;
        while (num <= limit)
        {
            bool isPrime = true;
            int i = 2;
            while (i * i <= num)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
                i++;
            }
            if (isPrime)
                Console.WriteLine(num);
            num++;
        }
    }

    // 4. Simulate a bank account where the user can deposit and withdraw using a do-while loop. The program should allow deposits and withdrawals until the user chooses to exit.
    static void program4()
    {
        double balance = 0;
        int choice;
        do
        {
            Console.WriteLine("\n1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter deposit amount: ");
                double amount = double.Parse(Console.ReadLine());
                balance += amount;
            }
            else if (choice == 2)
            {
                Console.Write(" Enter withdrawal amount: ");
                double amount = double.Parse(Console.ReadLine());
                if (amount > balance)
                    Console.WriteLine(" Insufficient funds!");
                else
                    balance -= amount;
            }
            Console.WriteLine($"Current Balance: {balance}")
            ;
        } while (choice != 3);
    }

    // 5. Find the largest prime factor of a number using a while loop. The program should compute the largest prime factor of a user-entered number.
    // (e.g. 26->13, 7->7)
    static void program5()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int factor = 2, largest = 1;
        while (num > 1)
        {
            while (num % factor == 0)
            {
                num = num / factor;
                largest = factor;
            }
            factor++;
        }
        Console.WriteLine($"Largest prime factor: {largest}");
    }

    // 6. Convert a decimal number to binary using a while loop. The program should take a decimal number and print its binary equivalent.
    // (e.g. 5->101, 12->1100)
    static void program6()
    {
        Console.Write(" Enter a decimal number : ");
        int num = int.Parse(Console.ReadLine());
        string binary = " ";
        while (num > 0)
        {
            binary = (num % 2) + binary;
            num = num / 2;
        }
        Console.WriteLine($"Binary representation: {binary}");

    }

    // 7. Calculate the Greatest Common Divisor (GCD) using the Euclidean Algorithm and a while loop. The program should take two numbers and compute their GCD using subtraction.
    // (e.g. 8,6->2 21,35->7)
    static void program7()
    {
        Console.Write(" Enter first number : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write(" Enter second number : ");
        int b = int.Parse(Console.ReadLine());
        while (a != 0 && b != 0)
        {
            if (a > b)
                a = a % b;
            else
                b = b % a;
        }
        Console.WriteLine($"GCD: {Math.Max(a, b)}"); //modified a bit. Let me know if you have more accurate answer.
    }

    // 8. Find the sum of factorials of each digit in a number using a while loop. The program should extract each digit and compute the factorial sum.
    // (e.g. 233->14, 54->144, 144->49, 504->144)
    static void program8()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        while (num != 0)
        {
            int digit = num % 10;
            int fact = 1;
            int i = 1;
            while (i <= digit)
            {
                fact *= i;
                i++;
            }
            if (digit != 0) // I think this if statement is required when decimals include zero (e.g. 504, 2270)
            {
                sum += fact;
            }
            num = (num - digit) / 10;
        }
        Console.WriteLine($"Sum of factorials: {sum}");
    }

    // 9. Implement a guessing game where the user has to guess a random number using a do-while loop. The program should generate a random number and ask the user to guess until they get it right.
    static void program9()
    {
        Random rand = new Random();
        int target = rand.Next(1, 100);
        int guess;
        do
        {
            Console.WriteLine("guessing game (1-100)");
            guess = int.Parse(Console.ReadLine());
            if (guess > target)
                Console.WriteLine("Too high!");
            else if (guess < target)
                Console.WriteLine("Too low!");
            else
                Console.WriteLine("Correct! You guessed it!"
                );
        } while (guess != target);
    }

    // 10.Simulate a vending machine with a menu using a do-while loop. The user should select an item until they decide to exit.
    static void program10()
    {
        int choice;
        do
        {
            Console.WriteLine("\nVending Machine Menu: ");
            Console.WriteLine("1. Soda - $1.50");
            Console.WriteLine("2. Chips - $1.00");
            Console.WriteLine("3. Chocolate - $2.00");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
                Console.WriteLine("You selected Soda.");
            else if (choice == 2)
                Console.WriteLine("You selected Chips.");
            else if (choice == 3)
                Console.WriteLine("You selected Chocolate.");
            else if (choice == 4)
                Console.WriteLine("Exiting ...");
            else
                Console.WriteLine("Invalid choice, try again.");
        } while (choice != 4);
    }
}