using System;
using static System.Console; // can be omitted "Console." in each rows because defined here.
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
        Console.WriteLine("--- Program5 ---");
        Program5();
        Console.WriteLine("--- Program6 ---");
        Program6();
        Console.WriteLine("--- Program7 ---");
        Program7();
        Console.WriteLine("--- Program8 ---");
        Program8();
        Console.WriteLine("--- Program9 ---");
        Program9();
        Console.WriteLine("--- Program10 ---");
        Program10();
        Console.WriteLine("--- Program11 ---");
        Program11();
        Console.WriteLine("--- Program12 ---");
        Program12();
        Console.WriteLine("--- Program13 ---");
        Program13();
        Console.WriteLine("--- Program14 ---");
        Program14();
        Console.WriteLine("--- Program15 ---");
        Program15();
        Console.WriteLine("--- Program16 ---");
        Program16();
        Console.WriteLine("--- Program17 ---");
        Program17();
        Console.WriteLine("--- Program18 ---");
        Program18();
    }

    // Squaring a Number
    static void Program1()
    {
        int aValue = int.Parse(Console.ReadLine());
        int result = aValue * aValue;
        Console.WriteLine("{0} squared is {1}", aValue, result);
    }

    // Calculating Miles Per Gallon
    static void Program2()
    {
        {
            Console.WriteLine("Miles per gallon = {0:N2}", CalculateMilesPerGallon(289, 12.2));
        }
    }
    static void Program3()
    {
        Console.WriteLine(" Miles per gallon = {0:N2}", CalculateMilesPerGallon(289, 12.2));
        Console.WriteLine(" Miles per gallon = {0}", CalculateMilesPerGallon(289, 12.2));
    }
    private static double CalculateMilesPerGallon(int milesTraveled, double gallonsUsed)
    {
        return milesTraveled / gallonsUsed;
    }

    static void Program4()
    {
        DoSomething(name: "John Doe", major: "Physics", age: 30); // able to define the certain parameters directly by using colon
    }
    private static void DoSomething(string name, int age = 21, bool currentStudent = true, string major = "CS") // 「int age = 21」 default.
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Student: {currentStudent}, Major: {major}");
    }


    static void Program5()
    {
        string aValue;
        int age;

        Write("Enter your age:");
        aValue = ReadLine();
        age = int.Parse(aValue);
        WriteLine("Your age next year will be {0}", ++age);
        ReadKey(); // wait to proceed unitl user press the key.
    }

    static void Program6()
    {
        int number;
        Write("Enter a number: ");
        number = int.Parse(ReadLine());
        WriteLine("The square root of {0} is {1}", number, Math.Sqrt(number));
        ReadKey();
    }

    // how to use methods that have same name but different
    static void Program7()
    {
        PrintMessage();
        PrintMessage("This is an overloaded method.");
    }
    private static void PrintMessage()
    {
        WriteLine("Hello, World!");
    }
    private static void PrintMessage(string message)
    {
        WriteLine("Message: " + message);
    }

    static void Program8()
    {
        int charValue;
        Write("Enter a character: ");
        charValue = Read(); // ASCII value
        WriteLine("ASCII value: " + charValue);
    }

    static void Program9()
    {
        string input;
        Write("Enter your name: ");
        input = ReadLine();
        WriteLine("Hello, " + input);
    }

    static void Program10()
    {
        double number = 78.926;
        WriteLine("Square Root: " + Math.Sqrt(number));
        WriteLine("Floor: " + Math.Floor(number));
        WriteLine("Rounded: " + Math.Round(number, 2));
    }

    // Value-Returning Method
    static void Program11()
    {
        double area = CalculateRectangleArea(5.5, 3.2);
        WriteLine(" Rectangle Area : " + area);
    }
    private static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }

    static void Program12()
    {
        int value = 10;
        DoubleValue(ref value);
        WriteLine("Doubled Value: " + value);
    }
    private static void DoubleValue(ref int number)
    {
        number *= 2;
    }

    static void Program13()
    {
        int num = 4, sq, cb;
        GetSquareAndCube(num, out sq, out cb);
        WriteLine($"Square: {sq}, Cube: {cb}");
    }
    private static void GetSquareAndCube(int number, out int square, out int cube)
    {
        square = number * number;
        cube = number * number * number;
    }

    static void Program14()
    {
        int sum = MathOperations.AddNumbers(5, 7); // it doesn't make instance because of static method
        WriteLine("Sum: " + sum);
    }

    static void Program15()
    {
        double cost = CalculateCost(10.5, 12.2, 15.0);
        WriteLine("Total Carpet Cost: $" + cost);
    }
    private static double CalculateCost(double width, double length, double pricePerSqYard)
    {
        double area = width * length;
        return area * pricePerSqYard;
    }

    static void Program16()
    {
        Console.Write("Enter temperature in Fahrenheit :");
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = ConvertToCelsius(fahrenheit);
        Console.WriteLine("Temperature in Celsius: {0:F2}", celsius);
    }
    private static double ConvertToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static void Program17()
    {
        double balance = 1000.50;
        DisplayBalance(balance);
        DisplayBalance(balance, "USD");
    }
    private static void DisplayBalance(double balance)
    {
        Console.WriteLine("Your balance :$" + balance);
    }
    private static void DisplayBalance(double balance, string currency)
    {
        Console.WriteLine("Your balance : {0} {1}", balance, currency);
    }

    static void Program18()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter your annual income: ");
        double income = double.Parse(Console.ReadLine());
        string resultMessage = " ";

        bool isEligible = CheckEligibility(age, income, ref resultMessage);
        Console.WriteLine(resultMessage);
    }
    private static bool CheckEligibility(int age, double income, ref string message)
    {
        if (age < 18)
        {
            message = "Not eligible: Must be at least 18 years old.";
            return false;
        }
        if (income < 25000)
        {
            message = "Not eligible: Minimum annual income must be $25,000.";
            return false;
        }
        message = "Congratulations! You are eligible for the loan.";
        return true;
    }
}

// for Program14
public class MathOperations
{
    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}