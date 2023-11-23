using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Nathan Harris", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment m1 = new MathAssignment("Ricky Bobby", "Fractions", "1.2", "1-2");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetMathInformation());

        WritingAssignment w1 = new WritingAssignment("Beth Hilton", "American History", "History at its Finest");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}