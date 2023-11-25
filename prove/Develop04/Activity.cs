public class Activity
{
    private string _name = "";
    private string _description = "";
    private int _duration = 0;

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine("Your activity will begin momentarily.");
        ShowSpinner(5);
        Console.WriteLine("\nActivity in progress...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job!");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($" {i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b");
        }
    }

}