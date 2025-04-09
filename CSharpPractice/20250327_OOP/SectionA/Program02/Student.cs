public class Student
{
    // Private fields
    private string studentNumber;
    private string firstName;
    private string lastName;
    private int score1;
    private int score2;
    private int score3;
    private string major;

    // Constructors
    public Student() { }
    public Student(string id)
    {
        studentNumber = id;
    }
    public Student(string id, string last, string first)
    {
        studentNumber = id;
        lastName = last;
        firstName = first;
    }
    public Student(string id, string last, string first,
    int s1, int s2, int s3, string maj)
    {
        studentNumber = id;
        lastName = last;
        firstName = first;
        score1 = s1;
        score2 = s2;
        score3 = s3;
        major = maj;
    }

    // Properties
    public string StudentNumber
    {
        get { return studentNumber; }
        set { studentNumber = value; }
    }
    public string StudentFirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string StudentLastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public string Major
    {
        get { return major; }
        set { major = value; }
    }
    public int Score1
    {
        get { return score1; }
        set { score1 = value; }
    }
    public int Score2
    {
        get { return score2; }
        set { score2 = value; }
    }
    public int Score3
    {
        get { return score3; }
        set { score3 = value; }
    }

    // Method : calculates average of three scores
    public double CalculateAverage()
    {
        return (score1 + score2 + score3) / 3.0;
    }
    public override string ToString()  // override ToString method that is located in C# library
    {
        return "Student: " + firstName + " " + lastName + "\nMajor: " + major + "\nAverage: " + CalculateAverage().ToString("F2");
    }
}