public class BreathingActivity : Activity
{
    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("Get ready for the Breathing Activity.");

        Console.Write("Breathe in: ");
        ShowCountDown(5);

        Console.WriteLine("\nNow, breathe out:");
        ShowCountDown(5);

        Console.WriteLine("\nBreathing activity completed.");
        DisplayEndingMessage();
    }
}