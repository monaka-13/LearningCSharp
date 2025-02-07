using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write(" Enter a number : ");
        int num = int.Parse(Console.ReadLine()); // Logical error : Should parse input
        Console.WriteLine(" Square : " + (num * num)); // Missing parentheses
    }
}
