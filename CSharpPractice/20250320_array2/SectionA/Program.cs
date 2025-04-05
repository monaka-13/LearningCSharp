using System;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        WriteLine("---Program01---");
        Program01();
        WriteLine("---Program02---");
        Program02();
        WriteLine("---Program03---");
        Program03();
        WriteLine("---Program04---");
        Program04();
        WriteLine("---Program05---");
        Program05();
        WriteLine("---Program06---");
        Program06();
        WriteLine("---Program07---");
        Program07();
        WriteLine("---Program08---");
        Program08();
        WriteLine("---Program09---");
        Program09();
        WriteLine("---Program10---");
        Program10();
        WriteLine("---Program11---");
        Program11();
        WriteLine("---Program12---");
        Program12();
        WriteLine("---Program13---");
        Program13();
    }

    static void Program01()
    {
        // Declare and initialize an array of strings
        string[] fruits = { "Apple", "Banana", "Cherry", "Mango" };
        // Display the elements
        WriteLine("Fruits in the array: ");
        foreach (string fruit in fruits)
        {
            WriteLine(fruit);
        }
    }

    static void Program02()
    {
        // Declare an array of strings with a fixed size
        string[] cities = new string[3];
        // Assign values using user input
        WriteLine("Enter 3 city names: ");
        for (int i = 0; i < cities.Length; i++)
        {
            cities[i] = ReadLine();
        }
        // Display the elements
        WriteLine("Cities you entered: ");
        foreach (string city in cities)
        {
            WriteLine(city);
        }
    }

    static void Program03()
    {
        // Initializing a string array using new keyword
        string[] colors = new string[] { "Red", "Green", "Blue" };
        // Displaying elements
        WriteLine("Colors available: ");
        foreach (string color in colors)
        {
            WriteLine(color);
        }
    }

    static void Program04()
    {
        string[] animals = { "Dog", "Cat", "Elephant", "Tiger" };
        // Accessing elements by index
        WriteLine("First animal: " + animals[0]);
        WriteLine("Third animal: " + animals[2]);
        // Modifying an element
        animals[1] = "Lion";
        WriteLine("Updated second animal: " +
        animals[1]);
    }

    static void Program05()
    {
        string[] countries = { "Canada", "USA", "Mexico", "Brazil" };
        WriteLine("List of countries: ");
        for (int i = 0; i < countries.Length; i++)
        {
            WriteLine(countries[i]);
        }
    }

    static void Program06()
    {
        string[] languages = { "C#", "Python", "Java", "JavaScript" };
        WriteLine("Programming languages: ");
        foreach (string lang in languages)
        {
            WriteLine(lang);
        }
    }

    static void Program07()
    {
        string[] sports = { "Football", "Basketball", "Cricket", "Tennis" };
        WriteLine("Popular sports: ");
        int i = 0;
        while (i < sports.Length)
        {
            WriteLine(sports[i]);
            i++;
        }
    }

    static void Program08()
    {
        string[] names = { "Zara", "Mike", "Adam", "Lucy" };
        WriteLine("Original order: ");
        foreach (string name in names)
        {
            WriteLine(name);
        }
        // Sorting the array
        Array.Sort(names);
        WriteLine("Sorted order : ");
        foreach (string name in names)
        {
            WriteLine(name);
        }
        // Reversing the array
        Array.Reverse(names);
        WriteLine("Reversed order: ");
        foreach (string name in names)
        {
            WriteLine(name);
        }
    }

    static void Program09()
    {
        Write("Enter number of strings: ");
        int size = int.Parse(ReadLine());
        string[] words = new string[size];
        WriteLine("Enter " + size + " words: ");
        for (int i = 0; i < size; i++)
        {
            words[i] = ReadLine();
        }
        Array.Sort(words);
        WriteLine("Sorted words: ");
        foreach (string word in words)
        {
            WriteLine(word);
        }
    }

    static void Program10()
    {
        Write("Enter number of strings: ");
        int size = int.Parse(ReadLine());
        string[] words = new string[size];
        WriteLine("Enter " + size + " words: ");
        for (int i = 0; i < size; i++)
        {
            words[i] = ReadLine();
        }
        Array.Reverse(words);
        WriteLine("Reversed words: ");
        foreach (string word in words)
        {
            WriteLine(word);
        }
    }

    static void Program11()
    {
        Write("Enter number of strings: ");
        int size = int.Parse(ReadLine());
        string[] words = new string[size];
        WriteLine("Enter " + size + " words: ");
        for (int i = 0; i < size; i++)
        {
            words[i] = ReadLine();
        }
        Write("Enter word to search: ");
        string searchWord = ReadLine();
        bool found = words.Contains(searchWord);
        if (found)
            WriteLine("Word found in the array.");
        else
            WriteLine("Word not found.");
    }

    static void Program12()
    {
        Write("Enter number of strings: ");
        int size = int.Parse(ReadLine());
        string[] words = new string[size];
        WriteLine("Enter " + size + " words: ");
        for (int i = 0; i < size; i++)
        {
            words[i] = ReadLine();
        }
        string result = String.Join(", ", words);
        WriteLine("Concatenated String: " + result);
    }

    static void Program13()
    {
        Write("Enter a sentence: ");
        string sentence = ReadLine();
        string[] words = sentence.Split(" ");
        WriteLine("Words in the sentence: ");
        foreach (string word in words)
        {
            WriteLine(word);
        }
    }
}