using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write(" Enter a number : ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0) // Check if number is positive
        {
            Console.WriteLine("The number is positive .");
        }
        else if (number < 0) // Check if number is negative
        {
            Console.WriteLine("The number is negative .");
        }
        else
        {
            Console.WriteLine("The number is zero .");
        }
    }
}