using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write(" Enter your age : ");
        int age = int.Parse(Console.ReadLine()); // Fill in to take age input
        int futureAge = age + 5; // Calculate age in 5 years
        Console.WriteLine($"In 5 years , you will be {futureAge} years old.");
    }
}