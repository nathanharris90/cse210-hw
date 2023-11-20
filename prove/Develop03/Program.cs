using System;
using System.Data.Common;
using System.Security.Cryptography;


class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Alma", 37, 36);
        Scripture s1 = new Scripture();
        Word u1 = new Word();
        string currentDisplay = s1.GetFullScripture();

        Console.Clear();

        Console.WriteLine(r1.GetReference() + currentDisplay);

        Console.WriteLine("Press the enter key to hide words, or press q and then enter to quit.");
        string _userInput = Console.ReadLine();

        while (_userInput != "q")
        {
            if (_userInput == "")
            {
                currentDisplay = u1.HideWord(currentDisplay);
                Console.Clear();
                Console.WriteLine(r1.GetReference() + currentDisplay);
                _userInput = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Please enter a valid argument. Press enter to hide words, or q to quit.");
                _userInput = Console.ReadLine();
            }
        }
    }
}