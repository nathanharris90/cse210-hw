using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favNum = PromptUserNumber();

        int favNumSqaured = SquareNumber(favNum);

        DisplayResult(userName, favNumSqaured);



        static void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write($"Username: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write($"What is your favorite number? ");
            int favNumInput = int.Parse(Console.ReadLine());
            return favNumInput;
        }
        static int SquareNumber(int favNum)
        {
            int squared = favNum * favNum;
            return squared;
        }
        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}.");
        }
    }
}