using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = 0;

        int maxNumber = 0;

        do
        {
            Console.Write("Input number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            if (userNumber > maxNumber)
            {
                maxNumber = userNumber;
            }
        } while (userNumber != 0);
        Console.WriteLine(numbers);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The max is: {maxNumber}");


    }
}