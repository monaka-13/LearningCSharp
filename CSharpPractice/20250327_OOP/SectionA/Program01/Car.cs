using System;
using static System.Console;

class Car
{
    public string color; // Attribute
    public int speed; // Attribute
                      // Method ( Behavior )
    public void Drive()
    {
        WriteLine($"The {color} car is driving at {speed} km/h.");
    }
}