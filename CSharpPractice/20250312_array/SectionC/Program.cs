using System;
using static System.Console;

class SectionC
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
        WriteLine("---Question 1: Reverse a One-Dimensional Array---");
        Write("Enter array size: ");
        int[] array = new int[int.Parse(ReadLine())];
        Write("Enter elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(ReadLine());
        }
        Write("Reversed Array: ");
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Write("{0} ", array[i]);
        }
    }

    static void Program2()
    {
        WriteLine("---Question 2: Find the Average of a One-Dimensional Array---");
        Write("Enter array size: ");
        int[] array = new int[int.Parse(ReadLine())];
        Write("Enter elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(ReadLine());
        }

        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        WriteLine("Average: {0:N1}", sum / array.Length);
    }

    static void Program3()
    {
        WriteLine("---Question 3: Find the Largest and Smallest Elements in a One-Dimensional Array---");
        Write("Enter array size: ");
        int[] array = new int[int.Parse(ReadLine())];
        Write("Enter elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(ReadLine());
        }

        int max = array[0];
        int min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
            if (min > array[i])
            {
                min = array[i];
            }
        }
        WriteLine("Largest value: {0}", max);
        WriteLine("Smallest value: {0}", min);
    }

    static void Program4()
    {
        WriteLine("---Question 4: Count Occurrences of a Number in a One-Dimensional Array---");
        Write("Enter array size: ");
        int[] array = new int[int.Parse(ReadLine())];
        Write("Enter elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(ReadLine());
        }
        Write("Enter number to count: ");
        int key = int.Parse(ReadLine());

        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (key == array[i])
            {
                count++;
            }
        }
        WriteLine("Number {0} appears {1} times.", key, count);
    }

    static void Program5()
    {
        WriteLine("---Question 5: Check if an Array is Sorted in Ascending Order---");
        Write("Enter array size: ");
        int[] array = new int[int.Parse(ReadLine())];
        Write("Enter elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(ReadLine());
        }
        WriteLine("The array {0} sorted in ascending order.", CheckAscendingOrder(array));
    }
    private static string CheckAscendingOrder(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return "isn't";
            }
        }
        return "is";
    }

}