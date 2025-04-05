using System;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Program01();
        //Program02();
        //Program03();
        //Program04();
        //Program05();
    }

    static void Program01()
    {
        WriteLine("---Program1: Reverse a String Array---");
        Write("Enter array size: ");
        int arraySize = int.Parse(ReadLine());
        string[] words = new string[arraySize];
        for (int i = 0; i < words.Length; i++)
        {
            Write("Enter word {0}: ", i + 1);
            words[i] = ReadLine();
        }
        WriteLine("Reversed array: ");
        for (int i = words.Length - 1; i >= 0; i--)
        {
            WriteLine("{0} ", words[i]);
        }
    }

    static void Program02()
    {
        WriteLine("---Program2: Sort a String Array Alphabetically---");
        Write("Enter array size: ");
        int arraySize = int.Parse(ReadLine());
        string[] words = new string[arraySize];
        for (int i = 0; i < words.Length; i++)
        {
            Write("Enter word {0}: ", i + 1);
            words[i] = ReadLine();
        }

        for (int i = 0; i < arraySize - 1; i++)
        {
            for (int j = 0; j < arraySize - i - 1; j++)
            {
                if (string.Compare(words[j], words[j + 1]) > 0)
                {
                    string temp = words[j];
                    words[j] = words[j + 1];
                    words[j + 1] = temp;
                }
            }
        }

        Write("Sorted array: ");
        foreach (string word in words)
        {
            Write("{0} ", word);
        }
        WriteLine();
    }

    static void Program03()
    {
        WriteLine("---Program3: Count Occurrences of a Specific String---");
        Write("Enter array size: ");
        int arraySize = int.Parse(ReadLine());
        string[] words = new string[arraySize];
        for (int i = 0; i < words.Length; i++)
        {
            Write("Enter word {0}: ", i + 1);
            words[i] = ReadLine();
        }
        Write("Enter word to count: ");
        String countWord = ReadLine();

        int count = 0;
        foreach (string word in words)
        {
            if (word == countWord)
            {
                count++;
            }
        }

        WriteLine("The word '{0}' appears {1} times.", countWord, count);
    }

    static void Program04()
    {
        WriteLine("---Program4: Concatenate a String Array into a Sentence---");
        Write("Enter array size: ");
        int arraySize = int.Parse(ReadLine());
        string[] words = new string[arraySize];
        for (int i = 0; i < words.Length; i++)
        {
            Write("Enter word {0}: ", i + 1);
            words[i] = ReadLine();
        }
        string sentence = "";
        for (int i = 0; i < arraySize; i++)
        {
            sentence = String.Join(" ", words);
        }
        WriteLine("Concatenated sentence: {0}", sentence);
    }

    static void Program05()
    {
        WriteLine("---Program5: Split a Sentence into a String Array and Display Each Word---");
        Write("Enter a sentence: ");
        String sentence = ReadLine();
        string[] words = sentence.Split(' ');
        foreach (string word in words)
        {
            WriteLine(word);
        }
    }

}