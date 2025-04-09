class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("1001", "Alice", "Lee", 88,
        91, 95, "CS");
        Console.WriteLine(s1); // Displays student info using ToString()
Console.WriteLine("Major: " + s1.Major); // Uses property
    }
}