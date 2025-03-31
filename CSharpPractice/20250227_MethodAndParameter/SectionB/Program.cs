using System;
using static System.Console;
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
    }

    // ## Problem 1: Convert Celsius to Fahrenheit
    //  - Convert a temperature given in Celsius to Fahrenheit.
    //  - Use a compile-time initialization of 32 for the Celsius value.
    //  - Convert using the formula: F = (C × 9 / 5) + 32
    //  - Display values properly formatted with one decimal place for Fahrenheit.
    //  - Modify the value and rerun the application.
    static void Program1()
    {
        WriteLine("--- Convert Celsius to Fahrenheit ---");
        // input
        Write("Input the Celsius temperature: ");
        double celsius = double.Parse(ReadLine());
        double fahrenheit = CelsiusToFahrenheit(celsius);
        // output
        WriteLine("Fahrenheit temperature: {0:F2}", fahrenheit);
    }
    static double CelsiusToFahrenheit(double celsius)
    {
        // calculate C to F
        double tempfahrenheit = (celsius * 9 / 5) + 32;

        // format with one decimal place
        return Math.Round(tempfahrenheit, 1, MidpointRounding.AwayFromZero);
    }

    // ## Problem 2: Convert Miles to Feet and Kilometers
    //  - Convert 4.5 miles into feet and kilometers.
    //  - Use the conversion formulas: 1 mile = 5280 feet, 1 mile = 1.60934 km
    //  - Ensure formatting includes comma separators for feet.
    //  - Modify the miles value and rerun the application.
    static void Program2()
    {
        WriteLine("--- Distanse calculator ---");
        // input
        Write("Input the distance (mile): ");
        double mile = double.Parse(ReadLine());

        // output
        ConvertMiles(mile, out double feet, out double km);
    }
    public static void ConvertMiles(double mile, out double feet, out double km)
    {
        feet = mile * 5280;
        km = mile * 1.60934;

        WriteLine($"feet is: {feet}ft");
        WriteLine($"kilometer is: {km}km");
    }

    // ## Problem 3: Compute Average of Exam Scores
    //  - Compute the average of five exam scores.
    //  - Use integer variables for the scores.
    //  - Display scores and average formatted with two decimal places.
    static void Program3()
    {
        WriteLine("--- Average calculator ---");

        Write("input 3 numbers: ");
        int[] scores = new int[3];
        scores[0] = int.Parse(ReadLine());
        scores[1] = int.Parse(ReadLine());
        scores[2] = int.Parse(ReadLine());

        // output
        double avg = ComputeAvarage(scores, 3);
        WriteLine($"The average is: {avg}.");
    }
    static double ComputeAvarage(int[] scores, int subs)
    {
        double sum = 0;
        for (int i = 0; i < 3; i++)
        {
            sum += scores[i];
        }
        return sum / subs;
    }
    public static void InputScore(String msg, List<int> scoreList)
    {
        Write(msg);
        scoreList.Add(int.Parse(ReadLine()));
    }

    // ## Problem 4: Compute Change in Coins
    //  - Calculate the number of quarters(25), dimes(10), nickels(5), and pennies(1) for a given amount of change.
    //  - Format the original amount with two decimal places.
    //  - Test the program with 92 cents, then modify it to 27 cents.
    static void Program4()
    {
        WriteLine("--- Changes ---");
        // input
        Write("Input the number: ");
        int cent = int.Parse(ReadLine());

        int quarter = MuchCent(cent, 25);
        cent -= (25 * quarter);

        int dime = MuchCent(cent, 10);
        cent -= (10 * dime);

        int nickel = MuchCent(cent, 5);

        int penny = cent - (5 * nickel);

        // output
        WriteLine("The change is: ");
        WriteLine($" quarter: {quarter}");
        WriteLine($" dime: {dime}");
        WriteLine($" nickel: {nickel}");
        WriteLine($" penny: {penny}");
    }
    static int MuchCent(int cent, int values)
    {
        return cent / values;
    }

    // ## Problem 5: Compute Retail Price with Markdown
    //  - Compute retail price after a 15% markdown.
    //  - Use an initial price of $41.00 for an item.
    //  - Modify the markdown to 10% and 20%, and display results.
    static void Program5()
    {
        WriteLine("--- Markdown price calculator ---");
        // input
        Write("Input the item price: ");
        int item = int.Parse(ReadLine());
        Write("Input the dicsount rate (%): ");
        double markdown = double.Parse(ReadLine());

        // output
        Output(item, markdown);
    }
    public static void Output(int item, double markdown)
    {
        WriteLine($"The price is: {item * (1 - markdown / 100)}");
    }

    // ## Problem 6: Compute Take-Home Pay for a Sales Employee
    //  - Compute commission and deductions for an employee.
    //  - Employee receives 7% commission, and deductions include:
    //   - 18% federal tax
    //   - 10% retirement contribution
    //   - 6% social security tax
    //  - Display total deductions and final take-home pay.
    static void Program6()
    {
        WriteLine("--- commission and deductions ---");
        // input
        Write("Input your salary ($/mo): ");
        double salary = double.Parse(ReadLine());
        double commission = salary * 0.07;
        double federalTax = salary * 0.18;
        double retirementContribution = salary * 0.1;
        double socialSecurityTax = salary * 0.06;

        // output
        Output(salary, commission, federalTax, retirementContribution, socialSecurityTax);
    }
    public static void Output(double salary, double commission, double federalTax, double retirementContribution, double socialSecurityTax)
    {
        WriteLine($"Your take-Home Pay is: ${salary + commission - federalTax - retirementContribution - socialSecurityTax}");
    }

    // ## Problem 7: Compute Restaurant Tips
    //  - Compute 15% and 20% tips on a bill.
    //  - Include a 9% tax before calculating the tip.
    //  - Display subtotal, tip amount, and total bill for both percentages.
    static void Program7()
    {
        WriteLine("--- Restaurant tips ---");
        // input
        Write("Input the bill: ");
        double bill = double.Parse(ReadLine());

        double subtotal = bill * 1.09;
        double tipTwenty = subtotal * 0.2;

        // output
        WriteLine("subtotal: {0:F2}", subtotal);
        OutputTip(subtotal, 15);
        OutputTip(subtotal, 20);
    }
    public static void OutputTip(double subtotal, int tipRate)
    {
        double tip = subtotal * tipRate / 100;
        WriteLine("tip amount ({0}%): {1:F2}", tipRate, subtotal);
        WriteLine("total ({0}%): {1:F2}", tipRate, subtotal + tip);
    }

    // ## Problem 8: Compute Weighted Average
    //  - Compute weighted average based on:
    //   - Homework: 10%
    //   - Projects: 35%
    //   - Quizzes: 10%
    //   - Exams: 30%
    //   - Final Exam: 15%
    //  - Display all values properly labeled.
    static void Program8()
    {
        WriteLine("--- weighted average ---");
        // input
        Write("Input your Homework score: ");
        int homework = int.Parse(ReadLine());
        Write("Input your Projects score: ");
        int projects = int.Parse(ReadLine());
        Write("Input your Quizzes score: ");
        int quizzes = int.Parse(ReadLine());
        Write("Input your Exams score: ");
        int exams = int.Parse(ReadLine());
        Write("Input your Final Exam score: ");
        int finalExam = int.Parse(ReadLine());

        // output
        Output(homework, projects, quizzes, exams, finalExam);
    }
    public static void Output(int homework, int projects, int quizzes, int exams, int finalExam)
    {
        WriteLine($"The weighted average: {(homework * 0.1) + (projects * 0.35) + (quizzes * 0.1) + (exams * 0.3) + (finalExam * 0.15)}");

    }
}