class Program
{
    static void Main(string[] args)
    {
        Activity act1 = new Activity();
        BreathingActivity breath1 = new BreathingActivity();
        ReflectingActivity reflect1 = new ReflectingActivity();
        ListingActivity list1 = new ListingActivity();

        while (true)
        {
            // Display menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            // Get user input
            Console.Write("Enter your choice (1-4): ");
            string input = Console.ReadLine();

            // Check user choice
            switch (input)
            {
                case "1":
                    Console.WriteLine("You selected Breathing Activity.");
                    breath1.DisplayStartingMessage();
                    break;
                case "2":
                    Console.WriteLine("You selected Reflecting Activity.");
                    reflect1.DisplayStartingMessage();
                    break;
                case "3":
                    Console.WriteLine("You selected Listing Activity.");
                    list1.DisplayStartingMessage();
                    break;
                case "4":
                    Console.WriteLine("You selected exit.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.Clear();
        }
    }
}