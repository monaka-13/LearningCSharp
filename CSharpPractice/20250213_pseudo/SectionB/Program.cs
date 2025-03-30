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

    // ## Program 1: Convert Celsius to Fahrenheit
    //  - Convert a temperature given in Celsius to Fahrenheit.
    //  - Use a compile-time initialization of 32 for the Celsius value.
    //  - Convert using the formula: F = (C × 9 / 5) + 32
    //  - Display values properly formatted with one decimal place for Fahrenheit.
    //  - Modify the value and rerun the application.
    static void program1()
    {
        Console.WriteLine("--- Convert Celsius to Fahrenheit ---");
        // input
        Console.Write("Input the Celsius temperature: ");
        double celsius = double.Parse(Console.ReadLine());

        // calculate C to F
        double tempfahrenheit = (celsius * 9 / 5) + 32;

        // format with one decimal place
        double fahrenheit = Math.Round(tempfahrenheit, 1, MidpointRounding.AwayFromZero);

        // output
        Console.WriteLine($"Fahrenheit temperature is: {fahrenheit}.");
    }

    // ## Program 2: Convert Miles to Feet and Kilometers
    //  - Convert 4.5 miles into feet and kilometers.
    //  - Use the conversion formulas: 1 mile = 5280 feet, 1 mile = 1.60934 km
    //  - Ensure formatting includes comma separators for feet.
    //  - Modify the miles value and rerun the application.
    static void program2()
    {
        Console.WriteLine("--- Distanse calculator ---");
        // input
        Console.Write("Input the distance (mile): ");
        double mile = double.Parse(Console.ReadLine());

        // output
        Console.WriteLine($"feet is: {mile * 5280}ft");
        Console.WriteLine($"kilometer is: {mile * 1.60934}km");
    }

    // ## Program 3: Compute Average of Exam Scores
    //  - Compute the average of five exam scores.
    //  - Use integer variables for the scores.
    //  - Display scores and average formatted with two decimal places.
    static void program3()
    {
        Console.WriteLine("--- Average calculator ---");
        List<int> scoreList = new List<int> { };

        // input
        Console.Write("Input the first exam score: ");
        scoreList.Add(int.Parse(Console.ReadLine()));
        Console.Write("Input the second exam score: ");
        scoreList.Add(int.Parse(Console.ReadLine()));
        Console.Write("Input the third exam score: ");
        scoreList.Add(int.Parse(Console.ReadLine()));
        Console.Write("Input the fourth exam score: ");
        scoreList.Add(int.Parse(Console.ReadLine()));
        Console.Write("Input the fifth exam score: ");
        scoreList.Add(int.Parse(Console.ReadLine()));

        // output
        Console.WriteLine($"The average is: {scoreList.Average()}.");
    }

    // ## Program 4: Compute Change in Coins
    //  - Calculate the number of quarters(25), dimes(10), nickels(5), and pennies(1) for a given amount of change.
    //  - Format the original amount with two decimal places.
    //  - Test the program with 92 cents, then modify it to 27 cents.
    static void program4()
    {
        Console.WriteLine("--- Changes ---");
        // input
        Console.Write("Input the number: ");
        int cent = int.Parse(Console.ReadLine());

        int quarter = cent / 25;
        cent -= (25 * quarter);

        int dime = cent / 10;
        cent -= (10 * dime);

        int nickel = cent / 5;

        int penny = cent - (5 * nickel);

        // output
        Console.WriteLine("The change is: ");
        Console.WriteLine($" quarter: {quarter}");
        Console.WriteLine($" dime: {dime}");
        Console.WriteLine($" nickel: {nickel}");
        Console.WriteLine($" penny: {penny}");
    }

    // ## Program 5: Compute Retail Price with Markdown
    //  - Compute retail price after a 15% markdown.
    //  - Use an initial price of $41.00 for an item.
    //  - Modify the markdown to 10% and 20%, and display results.
    static void program5()
    {
        Console.WriteLine("--- Markdown price calculator ---");
        // input
        Console.Write("Input the item price: ");
        int item = int.Parse(Console.ReadLine());
        Console.Write("Input the dicsount rate (%): ");
        double markdown = double.Parse(Console.ReadLine());

        // output
        Console.WriteLine($"The price is: {item * (1 - markdown / 100)}");
    }

    // ## Program 6: Compute Take-Home Pay for a Sales Employee
    //  - Compute commission and deductions for an employee.
    //  - Employee receives 7% commission, and deductions include:
    //   - 18% federal tax
    //   - 10% retirement contribution
    //   - 6% social security tax
    //  - Display total deductions and final take-home pay.
    static void program6()
    {
        Console.WriteLine("--- commission and deductions ---");
        // input
        Console.Write("Input your salary ($/mo): ");
        double salary = double.Parse(Console.ReadLine());
        double commission = salary * 0.07;
        double federalTax = salary * 0.18;
        double retirementContribution = salary * 0.1;
        double socialSecurityTax = salary * 0.06;

        // output
        Console.WriteLine($"Your take-Home Pay is: ${salary + commission - federalTax - retirementContribution - socialSecurityTax}");
    }

    // ## Program 7: Compute Restaurant Tips
    //  - Compute 15% and 20% tips on a bill.
    //  - Include a 9% tax before calculating the tip.
    //  - Display subtotal, tip amount, and total bill for both percentages.
    static void program7()
    {
        Console.WriteLine("--- Restaurant tips ---");
        // input
        Console.Write("Input the bill: ");
        double bill = double.Parse(Console.ReadLine());

        double subtotal = bill * 1.09;
        double tipFifteen = subtotal * 0.15;
        double tipTwenty = subtotal * 0.2;

        // output
        Console.WriteLine($"subtotal: {subtotal}");
        Console.WriteLine($"tip amount (15%): {tipFifteen}");
        Console.WriteLine($"total (15%): {subtotal + tipFifteen}");
        Console.WriteLine($"tip amount (20%): {tipTwenty}");
        Console.WriteLine($"total (20%): {subtotal + tipTwenty}");
    }

    // ## Program 8: Compute Weighted Average
    //  - Compute weighted average based on:
    //   - Homework: 10%
    //   - Projects: 35%
    //   - Quizzes: 10%
    //   - Exams: 30%
    //   - Final Exam: 15%
    //  - Display all values properly labeled.
    static void program8()
    {
        Console.WriteLine("--- weighted average ---");
        // input
        Console.Write("Input your Homework score: ");
        int homework = int.Parse(Console.ReadLine());
        Console.Write("Input your Projects score: ");
        int projects = int.Parse(Console.ReadLine());
        Console.Write("Input your Quizzes score: ");
        int quizzes = int.Parse(Console.ReadLine());
        Console.Write("Input your Exams score: ");
        int exams = int.Parse(Console.ReadLine());
        Console.Write("Input your Final Exam score: ");
        int finalExam = int.Parse(Console.ReadLine());

        // output
        Console.WriteLine($"The weighted average: {(homework * 0.1) + (projects * 0.35) + (quizzes * 0.1) + (exams * 0.3) + (finalExam * 0.15)}");
    }

    // ## Program 9: Compute Club Earnings from Granola Sales
    //  - Compute total earnings from granola sales.
    //  - Each case contains 12 bars and costs $5.00 per case.
    //  - The club gives 10% of earnings to the student government.
    static void program9()
    {
        Console.WriteLine("--- Total earnings ---");
        // input
        Console.Write("How many granola sold?: ");
        int bar = int.Parse(Console.ReadLine());
        // output
        Console.WriteLine($"Earnings: ${bar / 12 * 5 * 0.9}");
    }

    // ## Program 10: Convert Grams to Pounds and Calculate Price per Pound
    //  - Convert a given mass in grams into pounds. (1lb≒453.592g)
    //  - Compute price per pound.
    //  - Test with Poutine ($1.29 per 100g) and Haricot Verts ($0.75 per 100g).
    static void program10()
    {
        Console.WriteLine("--- Pound price ---");
        // input
        Console.Write("How much it per 100g?: ");
        double priceGram = double.Parse(Console.ReadLine());

        double pricePound = priceGram * 453.592; // 1lb≒453.592g

        // output
        Console.WriteLine($"price: ${pricePound}/lb");
    }

    // ## Program 11: Display User’s Name and Favorite Saying
    //  - Prompt the user to enter their name and favorite saying.
    //  - Display the message formatted with symbols (<><><>) around it.
    static void program11()
    {
        Console.WriteLine("--- formatted with carets ---");
        // input
        Console.Write("Input your name: ");
        string name = "name: " + Console.ReadLine();
        Console.Write("Input your favorite saying: ");
        string saying = "saying: " + Console.ReadLine();

        int length = Math.Max(name.Length, saying.Length);

        // output
        for (int i = 0; i < (length / 2) + 2; i++)
        {
            Console.Write("<>");
        }

        Console.WriteLine($"\n {name}");
        Console.WriteLine($" {saying}");

        for (int j = 0; j < (length / 2) + 2; j++)
        {
            Console.Write("<>");
        }
    }

    // ## Program 12: Display School Information
    //  - Display information about your school, including:
    //   - School name
    //   - Number of students enrolled
    //   - School colors
    //  - Format the output with surrounding asterisks (**********).
    static void program12()
    {
        Console.WriteLine("--- formatted with asterisks ---");
        // input
        Console.Write("Input your school: ");
        string name = "school: " + Console.ReadLine();
        Console.Write("Input number of students: ");
        string students = "Number of students: " + Console.ReadLine();
        Console.Write("Input your school colors: ");
        string color = "color: " + Console.ReadLine();

        int nameLength = name.Length;
        int studentsLength = students.Length;
        int colorLength = color.Length;
        int maxLength = Math.Max(Math.Max(nameLength, studentsLength), colorLength);

        if (maxLength != nameLength)
        {
            for (int n = 1; n <= maxLength - nameLength; nameLength++)
            {
                name += " ";
            }
        }

        if (maxLength != studentsLength)
        {
            for (int s = 1; s <= maxLength - studentsLength; studentsLength++)
            {
                students += " ";
            }
        }

        if (maxLength != colorLength)
        {
            for (int c = 1; c <= maxLength - colorLength; colorLength++)
            {
                color += " ";
            }
        }

        // output
        for (int i = 0; i < maxLength + 4; i++)
        {
            Console.Write("*");
        }

        Console.Write($"\n* {name} *");
        Console.Write($"\n* {students} *");
        Console.Write($"\n* {color} *\n");

        for (int i = 0; i < maxLength + 4; i++)
        {
            Console.Write("*");
        }
    }

    // ## Program 13: Convert Seconds into Hours, Minutes, and
    // Seconds
    //  - Allow the user to enter a total number of seconds.
    //  - Convert and display the corresponding hours, minutes, and remaining seconds.
    static void program13()
    {
        Console.WriteLine("--- time converter ---");
        // input
        Console.Write("Input the seconds: ");
        int second = int.Parse(Console.ReadLine());
        int hour = second / 3600;
        int minute = second / 60 - hour * 60;
        second %= 60;

        // output
        Console.WriteLine($"hours: {hour}, minutes: {minute}, seconds:{second}");
    }

    // ## Program 14: Convert Meters to Feet and Inches
    //  - Convert a given metric meter value into feet and inches.
    //  - Use the conversions: 1 meter = 3.28084 feet, 1 foot = 12 inches
    //  - Display the results properly labeled and number-aligned.
    static void program14()
    {
        Console.WriteLine("--- length converter ---");
        // input
        Console.Write("Input meter: ");
        double meter = double.Parse(Console.ReadLine());
        double feet = meter * 3.28084;
        double inches = feet * 12;

        // output
        Console.WriteLine($"in feet: {feet}");
        Console.WriteLine($"in inches: {inches}");
    }

    // ## Program 15: Property Tax Calculation
    //  - Allow the user to enter:
    //   - Property address
    //   - Prior year’s assessed value
    //  - Increase the assessed value by 2.7%.
    //  - Apply a $25,000 exemption before computing tax.
    //  - Compute property tax using a millage rate of $10.03 per $1000.
    //  - Display:
    //   - New assessed value
    //   - Taxable value after exemption
    //   - Total property tax due
    static void program15()
    {
        Console.WriteLine("--- Property Tax calculator ---");
        // input
        Console.Write("Input the property address: ");
        string property = Console.ReadLine();
        Console.Write("Input the prior year’s assessed value: ");
        double priorYear = double.Parse(Console.ReadLine());

        double newAssessed = priorYear * 1.027;
        double exemption = newAssessed - 25000;
        double total = exemption * 10.03 / 1000;

        // output
        Console.WriteLine($"property address: {property}");
        Console.WriteLine($"New assessed value: {newAssessed}");
        Console.WriteLine($"Taxable value after exemption: {exemption}");
        Console.WriteLine($"Total property tax due: {total}");
    }

}