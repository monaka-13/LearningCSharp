using System;
using static System.Console;

class SectionA
{
    public static void Main(String[] args)
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
    }

    static void Program1()
    {
        int[] numbers = new int[5]; // Array of size 5

        // Assigning values
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;
        // Accessing values
        WriteLine(numbers[2]); // Outputs 30
    }
    static void Program2()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        WriteLine("- Using a for loop");
        for (int i = 0; i < numbers.Length; i++)
        {
            WriteLine(numbers[i]);
        }
        // Using a foreach loop
        WriteLine("- Using a foreach loop");
        foreach (int num in numbers)
        {
            WriteLine(num);
        }
    }
    static void Program3()
    {
        int[,] matrix = {
            {1 , 2 , 3},
            {4 , 5 , 6},
            {7 , 8 , 9}
        };
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Write(matrix[row, col] + " ");
            }
            WriteLine();
        }
    }
    static void Program4()
    {
        int[,] array = new int[4, 5];
        WriteLine(array.Length); // Outputs 20
        WriteLine(array.GetLength(0)); // Outputs 4 (rows)
        WriteLine(array.GetLength(1)); // Outputs 5 (columns)
        WriteLine(array.Rank); // Outputs 2
    }
    static void Program5()
    {
        int[][] jaggedArray = {
            new int [] {1, 2, 3},
            new int [] {4, 5},
            new int [] {6, 7, 8, 9}
        };
        // Iterating through jagged array
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Write(jaggedArray[i][j] + " ");
            }
            WriteLine();
        }
    }
}