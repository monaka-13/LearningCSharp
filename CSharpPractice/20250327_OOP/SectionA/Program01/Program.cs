using System;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car(); // Create an object
        myCar.color = "Red"; // Set attribute values
        myCar.speed = 100;
        myCar.Drive(); // Call method

    }
}