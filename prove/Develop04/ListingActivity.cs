public class ListingActivity : Activity
{
    private static readonly List<string> ListingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("Welcome to Listing Activity!");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.Write("Enter the duration for this activity in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            ListItems(duration);
        }
        else
        {
            Console.WriteLine("Invalid input. Using default duration of 60 seconds.");
            ListItems(60);
        }

        Console.WriteLine("\nListing activity completed.");
        DisplayEndingMessage();
    }

    private void ListItems(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random random = new Random();

        string randomPrompt = ListingPrompts[random.Next(ListingPrompts.Count)];
        Console.WriteLine($"\nThink about the following prompt:\n{randomPrompt}");

        Console.WriteLine($"You have {duration} seconds to list as many items as you can.");

        Thread.Sleep(3000);
        Console.Write("Get ready... ");
        ShowCountDown(3);

        Console.WriteLine("\nGo!");

        List<string> itemsList = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            itemsList.Add(item);
        }

        Console.WriteLine($"\nYou listed {itemsList.Count} items.");
    }
}