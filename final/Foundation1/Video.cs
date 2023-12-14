public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _commentList = new List<Comment>();

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of Comments: {CountComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in _commentList)
        {
            Console.WriteLine($"{comment._name}: {comment._commentText}");
        }
        Console.WriteLine();
    }

    public void AddComment(Comment newComment)
    {
        _commentList.Add(newComment);
    }

    public int CountComments() // Fix the return type of the method
    {
        return _commentList.Count;
    }
}