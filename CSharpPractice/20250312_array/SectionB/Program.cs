using System;
using static System.Console;

class SectionB
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
    }
    static void Program1()
    {
        Console.Write("Enter array size : ");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];
        Console.WriteLine("Enter " + size + " elements: ");
        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Elements of the 1D array: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static void Program2()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];
        Console.WriteLine("Enter " + size + " elements: ");
        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int max = numbers[0];
        for (int i = 1; i < size; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine("Maximum value in array: " + max);
    }
    static void Program3()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Enter " + (rows * cols) + " elements: ");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(Console.
                ReadLine());
            }
        }
        Console.WriteLine("Elements of the 2D array: ");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
    static void Program4()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Enter " + (rows * cols) + " elements: ");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(Console.
                ReadLine());
            }
        }
        for (int row = 0; row < rows; row++)
        {
            int rowSum = 0;
            for (int col = 0; col < cols; col++)
            {
                rowSum += matrix[row, col];
            }
            Console.WriteLine("Sum of row" + (row + 1) + ": " + rowSum);
        }
    }
}