public class Word
{
    public string HideWord(string currentDisplay)
    {
        string[] _spliced = currentDisplay.Split(' ');
        Random random = new Random();

        int remainingWords = _spliced.Length;
        if (remainingWords > 0)
        {
            int randomIndex = random.Next(0, _spliced.Length);
            _spliced[randomIndex] = new string('_', _spliced[randomIndex].Length);
            string updatedDisplay = string.Join(" ", _spliced);
            return updatedDisplay;
        }
        else
        {
            string end = "All the words are gone";
            return end;
        }
    }
}