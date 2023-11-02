using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your GPA? ");
        float gpa = float.Parse(Console.ReadLine());

        string grade = "";

        if (gpa >= 90)
        {
            grade = "A";
        }
        else if (gpa >= 80)
        {
            grade = "B";
        }
        else if (gpa >= 70)
        {
            grade = "C";
        }
        else if (gpa >= 60)
        {
            grade = "D";
        }
        else if (gpa < 60)
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is a {grade}.");

        if (gpa >= 70)
        {
            Console.WriteLine("Congradulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You did not pass the class.");
        }
    }
}