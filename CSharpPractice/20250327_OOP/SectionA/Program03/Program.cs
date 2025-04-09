class Program
{
    internal static void Main(string[] args)
    {
        Console.Write("Enter Student Number: ");
        string studentNumber = Console.ReadLine();
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter Major: ");
        string major = Console.ReadLine();
        Console.Write("Enter Score 1: ");
        int score1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Score 2: ");
        int score2 = int.Parse(Console.ReadLine());
        Console.Write("Enter Score 3: ");
        int score3 = int.Parse(Console.ReadLine());
        // Create the Student object using user input
        Student s1 = new Student(studentNumber, lastName, firstName, score1, score2, score3, major);
        Console.WriteLine(); // Add spacing
        Console.WriteLine(" Student Details: ");
        Console.WriteLine(s1); // Automatically calls ToString()
    }
}