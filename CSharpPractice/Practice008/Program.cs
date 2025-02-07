using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write(" Enter the length : ");
        int length = int.Parse(Console.ReadLine()); // Fill in to take length input
        Console.Write(" Enter the width : ");
        int width = int.Parse(Console.ReadLine()); // Fill in to take width input
        int area = length * width; // Calculate area
        Console.WriteLine($"The area of the rectangle is {area}.");
    }
}
