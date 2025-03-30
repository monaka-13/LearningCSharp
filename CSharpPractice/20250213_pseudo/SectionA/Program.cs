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
        Console.WriteLine("--- Program11 ---");
        program11();
        Console.WriteLine("--- Program12 ---");
        program12();
        Console.WriteLine("--- Program13 ---");
        program13();
        Console.WriteLine("--- Program14 ---");
        program14();
        Console.WriteLine("--- Program15 ---");
        program15();
    }

    // program 1: Check if a Number is a Palindrome
    static void program1()
    {
        Console.WriteLine("---Palindrome checker---");
        Console.WriteLine("Input your number");
        int original = int.Parse(Console.ReadLine());
        int copiedOriginal = original;
        int rev = 0;
        while (copiedOriginal != 0)
        {
            int digit = copiedOriginal % 10;
            rev = rev * 10 + digit;
            copiedOriginal = (copiedOriginal - digit) / 10;
        }
        if (original == rev)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("not Palindrome");
        }
    }

    // program 2: Find the Sum of All Even Digits in a Number
    static void program2()
    {
        Console.WriteLine("---Find the Sum of All Even Digits---");
        Console.WriteLine("Input the number");
        int input = int.Parse(Console.ReadLine());
        int copiedInput = input;
        int sum = 0;
        while (copiedInput > 0)
        {
            int digit = copiedInput % 10;
            if (digit % 2 == 0)
            {
                sum = sum + digit;
            }
            copiedInput = (copiedInput - digit) / 10;
        }
        Console.WriteLine($"The answer is {sum}");
    }

    // program 3: Generate Prime Numbers up to a Given Limit
    static void program3()
    {
        Console.WriteLine("---Prime Numbers up to a Given Limit---");
        Console.Write("Input the number: ");
        int input = int.Parse(Console.ReadLine());
        int prime = 2;
        while (prime <= input)
        {
            bool isPrime = true;
            int counter = 2;
            while (counter <= prime - 1)
            {
                if (prime % counter == 0)
                {
                    isPrime = false;
                    break;
                }
                counter++;
            }
            if (isPrime)
            {
                Console.WriteLine(prime);
            }
            prime++;
        }
    }

    // program 4: Simulate a Bank Account Using a Do-While Loop
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
                Console.Write("Enter withdrawal amount: ");
                double amount = double.Parse(Console.
                ReadLine());
                if (amount > balance)
                    Console.WriteLine(" Insufficient funds!");
                else
                    balance -= amount;
            }
            Console.WriteLine($" Current Balance : {balance}");
        } while (choice != 3);
    }

    // program 5: Convert Decimal to Binary Using a While Loop
    static void program5()
    {
        Console.WriteLine("---Decimal to Binary converter---");
        Console.Write("Enter a decimal number: ");
        int num = int.Parse(Console.ReadLine());
        string binary = "";
        while (num > 0)
        {
            binary = (num % 2) + binary;
            num = num / 2;
        }
        Console.WriteLine($"Binary representation: {binary}");
    }

    //Program 6: Find the Greatest Common Divisor (GCD) Using the Euclidean Algorithm
    static void program6()
    {
        Console.WriteLine("---GCD calculator---");
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        while (a != b)
        {
            if (a > b)
                a = a - b;
            else
                b = b - a;
        }
        if (a == 0)
        {
            Console.WriteLine($"GCD: {b}");
        }
        else
        {
            Console.WriteLine($"GCD: {a}");
        }
    }

    // Program 7: Find the Largest Prime Factor of a Number
    static void program7()
    {
        Console.WriteLine("---Largest Prime Factor---");
        Console.Write(" Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int factor = 2;
        int largest = 1;
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

    // program 8: Check if a Number is an Armstrong Number
    // 153, 9474
    static void program8()
    {
        Console.WriteLine("---Armstrong Number calculator---");
        Console.Write("Enter a input: ");
        int input = int.Parse(Console.ReadLine());
        int sum = 0;
        int copiedInput = input;
        int digits = 0;
        while (copiedInput > 0)
        {
            copiedInput = copiedInput / 10;
            digits++;
        }
        copiedInput = input;
        while (copiedInput > 0)
        {
            sum = sum + (int)Math.Pow(copiedInput % 10, digits);
            copiedInput = copiedInput / 10;
        }
        if (sum == input)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }

    // program 9: Implement a Guessing Game
    static void program9()
    {
        Console.WriteLine("---Guess Number game---");
        Random random = new Random();
        int target = random.Next(1, 100);
        int guess;
        do
        {
            Console.Write("Enter your guess (1-100): ");
            guess = int.Parse(Console.ReadLine());
            if (guess > target)
                Console.WriteLine("Too high!");
            else if (guess < target)
                Console.WriteLine("Too low!");
        } while (guess != target);
        Console.WriteLine("Correct! You guessed it!");
    }

    // program 10: Simulate a Vending Machine
    static void program10()
    {
        Console.WriteLine("---Vending Machine---");
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

    // program 11: Calculate the Area of a Circle
    static void program11()
    {
        Console.WriteLine("---Circle Calculator---");
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area of the circle: {area}");
    }

    // program 12: Calculate Simple Interest
    static void program12()
    {
        Console.WriteLine("---Simple interest calculator---");
        Console.Write("Enter principal amount: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter annual interest rate (in%): ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter time in years: ");
        double time = double.Parse(Console.ReadLine());
        Console.WriteLine($"The answer is {(principal * rate * time) / 100}");
    }

    // program 13: Calculate the Sum of the First N Natural Numbers
    static void program13()
    {
        Console.WriteLine("---Sum of the First N Natural Numbers---");
        Console.Write("Enter a number (N): ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0, i = 1;
        while (i <= n)
        {
            sum += i;
            i++;
        }
        Console.WriteLine($"Sum of first {n} natural numbers: {sum}");
    }

    // program 14: Convert Fahrenheit to Celsius
    static void program14()
    {
        Console.WriteLine("---Temperature converter---");
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Temperature in Celsius: {celsius}");
    }

    // program 15: Find the Factorial of a Given Number
    static void program15()
    {
        Console.WriteLine("---Factorial of a Given Number---");
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        double fact = 1;
        int i = 1;
        while (i <= num)
        {
            fact *= i;
            i++;
        }
        Console.WriteLine($"Factorial: {fact}");
    }
}