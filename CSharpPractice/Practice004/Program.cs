using System;
class Practice004
{
    static void Main(string[] args)
    {
        Console.Write(" Enter the first number : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write(" Enter the second number : ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sum : {num1 + num2}");
        Console.WriteLine($" Difference : {num1 - num2}");
        Console.WriteLine($" Product : {num1 * num2}");
        Console.WriteLine($" Quotient : {(float)num1 / num2}")
        ;
    }
}
