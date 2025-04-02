using System;
using static System.Console;

class Recap
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
    }
    static void Program1()
    {
        WriteLine("--- Library Fine Calculator Problem Statement ---");
        Write("How many overdue days?: ");
        int overdue = int.Parse(ReadLine());

        Write("The fine is ${0}", CalculateFine(overdue));
    }
    private static double CalculateFine(int overdue)
    {
        if (overdue >= 1 && overdue <= 5)
        {
            return overdue;
        }
        else if (overdue >= 6 && overdue <= 10)
        {
            return overdue * 1.5;
        }
        else if (overdue > 10)
        {
            return overdue * 2;
        }
        return 0; // no overdue days
    }

    static void Program2()
    {
        WriteLine("--- Fuel Efficiency Tracker ---");
        Write("Enter miles driven: ");
        double miles = double.Parse(ReadLine());
        Write("Enter gallons used: ");
        double gallons = double.Parse(ReadLine());
        WriteLine("Miles per gallon: {0} MPG", (CalculateMPG(miles, gallons)));
    }
    private static double CalculateMPG(double miles, double gallons)
    {
        return miles / gallons;
    }

    static void Program3()
    {
        WriteLine("--- Toll Booth System Problem Statement ---");
        Write("Enter vehicle type (Car/Truck/Motorcycle): ");
        string vehicleType = ReadLine();
        switch (vehicleType)
        {
            case "Car":
                WriteLine("Toll fee: $3");
                break;
            case "Truck":
                WriteLine("Toll fee: $6");
                break;
            case "Motrocycle":
                WriteLine("Toll fee: $2");
                break;
            default:
                WriteLine("error for invalid input");
                break;
        }
    }

    static void Program4()
    {
        WriteLine("--- Credit Card Interest Calculator ---");
        Write("Enter your credit card balance: ");
        double balance = double.Parse(ReadLine());
        Write("Total balance after interest: ${0:F2}", CalculateInterest(balance));
    }
    private static double CalculateInterest(double balance)
    {
        if (balance >= 1000)
        {
            return balance * 1.02;
        }
        else
        {
            return balance * 1.015;
        }
    }

    static void Program5()
    {
        WriteLine("--- Online Store Discount System Problem Statement ---");
        Write("Enter purchase amount: ");
        double amount = double.Parse(ReadLine());
        WriteLine("Final price after discount: ${0:F2}", CalculateDiscount(amount));
    }
    private static double CalculateDiscount(double amount)
    {
        if (amount <= 50)
        {
            return amount;
        }
        else if (amount > 50 && amount <= 100)
        {
            return amount * 0.95;
        }
        else
        {
            return amount * 0.9;
        }
    }

    static void Program6()
    {
        WriteLine("--- Smart Water Usage Monitor ---");
        Write("Enter water usage (liters): ");
        int usage = int.Parse(ReadLine());
        WriteLine("Total bill: ${0}", CalculateWaterBill(usage));
    }
    private static double CalculateWaterBill(int usage)
    {
        if (usage <= 1000)
        {
            return usage * 0.01;
        }
        else
        {
            return 1000 * 0.01 + (usage - 1000) * 0.02;
        }
    }

    static void Program7()
    {
        WriteLine("--- Speeding Ticket System Problem Statement ---");
        Write("Enter speed limit: ");
        int limit = int.Parse(ReadLine());
        Write("Enter vehicle speed: ");
        int speed = int.Parse(ReadLine());
        Write("Fine: ${0}", CalculateFine(speed - limit));
    }
    private static int CalculateFine(int over)
    {
        if (over <= 0)
        {
            return 0;
        }
        else if (over <= 10)
        {
            return 50;
        }
        else if (over <= 20)
        {
            return 100;
        }
        else
        {
            return 200;
        }
    }

    static void Program8()
    {
        WriteLine("--- ATM Withdrawal System ---");
        int action;
        double balance = 0;
        do
        {
            WriteLine("1. Deposit Money");
            WriteLine("2. Withdraw Money");
            WriteLine("3. Check Balance");
            WriteLine("4. Exit");
            Write("Enter action: ");
            action = int.Parse(ReadLine());
            double amount;

            if (action == 1)
            {
                Write("Enter amount: ");
                amount = double.Parse(ReadLine());
                balance = Deposit(balance, amount);
            }
            else if (action == 2)
            {
                Write("Enter amount: ");
                amount = double.Parse(ReadLine());
                balance = Withdraw(balance, amount);
            }
            else if (action == 3)
            {
                CheckBalance(balance);
            }
        } while (action != 4);
        Write("Thank you");
    }
    private static double Deposit(double balance, double amount)
    {
        WriteLine("done");
        return balance + amount;
    }
    private static double Withdraw(double balance, double amount)
    {
        if (balance < amount)
        {
            WriteLine("balance is lower than you want to withdraw");
            return balance;
        }
        WriteLine("done");
        return balance - amount;
    }
    private static void CheckBalance(double balance)
    {
        WriteLine($"balance is ${balance}");
    }

    static void Program9()
    {
        WriteLine("--- Online Exam Grading System Problem Statement ---");
        Write("Enter exam score: ");
        int score = int.Parse(ReadLine());
        string grade;
        if (score > 100 || score < 0)
        {
            grade = "no contest";
        }
        else if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "Fail";
        }
        WriteLine($"Grade: {grade}");
    }

    static void Program10()
    {
        WriteLine("--- Parking Garage Fee Calculation Problem Statement ---");
        Write("Enter parking hours: ");
        int hours = int.Parse(ReadLine());
        WriteLine("Total parking fee: ${0}", CalculateFee(hours));
    }
    private static int CalculateFee(int hours)
    {
        int fee;
        if (hours <= 2)
        {
            fee = hours * 5;
        }
        else
        {
            fee = 2 * 5 + (hours - 2) * 3;
        }

        if (fee > 25)
        {
            return 25;
        }

        return fee;
    }

    static void Program11()
    {
        WriteLine("--- Grocery Store Self-Checkout System ---");
        Write("Enter number of items: ");
        int itemCount = int.Parse(ReadLine());
        double[] prices = new double[itemCount];

        for (int i = 0; i < itemCount; i++)
        {
            Write($"Enter prices {i + 1}: $");
            prices[i] = double.Parse(ReadLine());
        }

        WriteLine("Total bill after discount: ${0}", CalculateTotal(prices, itemCount));
    }
    private static double CalculateTotal(double[] prices, int itemCount)
    {
        double sum = 0;
        for (int i = 0; i < itemCount; i++)
        {
            sum += prices[i];
        }

        if (sum > 100)
        {
            return sum * 0.95;
        }
        return sum;
    }

    static void Program12()
    {
        WriteLine("--- Bus Fare Calculation Problem Statement ---");
        Write("Enter age: ");
        int age = int.Parse(ReadLine());
        String fare;
        if (age <= 5)
        {
            fare = "Free";
        }
        else if (age <= 18)
        {
            fare = "2";
        }
        else if (age <= 60)
        {
            fare = "5";
        }
        else
        {
            fare = "3";
        }
        WriteLine($"Bus fare: ${fare}");
    }

    static void Program13()
    {
        WriteLine("--- Fitness Tracker ---");
        Write("Enter exercise type (Running/Cycling/Walking): ");
        string activityType = ReadLine();
        Write("Enter duration (minutes): ");
        int duration = int.Parse(ReadLine());

        WriteLine("Total calories burned: {0}", CalculateCalories(activityType, duration));
    }
    private static int CalculateCalories(string activityType, int duration)
    {
        if (activityType == "Running")
        {
            return 10 * duration;
        }
        else if (activityType == "Cycling")
        {
            return 7 * duration;
        }
        else if (activityType == "Walking")
        {
            return 5 * duration;
        }
        return 0;
    }

    static void Program14()
    {
        WriteLine("--- Smart Thermostat Alert ---");
        Write("Enter temperature: ");
        int temp = int.Parse(ReadLine());

        WriteLine("Alert: {0}", GetTemperatureAlert(temp));
    }
    private static string GetTemperatureAlert(int temp)
    {
        if (temp <= 5)
        {
            return "Very Cold";
        }
        else if (temp < 25)
        {
            return "Comfortable";
        }
        return "Too Hot";
    }

    static void Program15()
    {
        WriteLine("--- ATM Withdrawal System ---");
        int action;
        double balance = 0;
        do
        {
            WriteLine("1. Deposit");
            WriteLine("2. Withdraw");
            WriteLine("3. Check Balance");
            WriteLine("4. Exit");
            Write("Enter your choice: ");
            action = int.Parse(ReadLine());
            double amount;

            if (action == 1)
            {
                Write("Enter deposit amount: ");
                amount = double.Parse(ReadLine());
                balance += amount;
            }
            else if (action == 2)
            {
                Write("Enter withdrawal amount: ");
                amount = double.Parse(ReadLine());

                if (balance < amount)
                {
                    WriteLine("Withdrawals exceeds balance");
                }
                else
                {
                    balance = balance - amount;
                }
            }
            else if (action == 3)
            {
                WriteLine($"Current Balance: {balance}");
            }
        } while (action != 4);
        Write("Exiting...");
    }
}