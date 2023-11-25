public class ReflectingActivity : Activity
{
    private List<string> ReflectingPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> ReflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("Welcome to Reflecting Activity!");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Console.Write("Enter the duration for this activity in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Reflect(duration);
        }
        else
        {
            Console.WriteLine("Invalid input. Using default duration of 60 seconds.");
            Reflect(60);
        }

        Console.WriteLine("\nReflecting activity completed.");
        DisplayEndingMessage();
    }

    private void Reflect(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random random = new Random();

        while (DateTime.Now < endTime)
        {
            string randomPrompt = ReflectingPrompts[random.Next(ReflectingPrompts.Count)];
            Console.WriteLine($"\nReflect on the following prompt:\n{randomPrompt}");

            foreach (string question in ReflectionQuestions)
            {
                Console.Write($"{question} ");
                ShowSpinner(10);
                Console.WriteLine();
            }
        }
    }
}