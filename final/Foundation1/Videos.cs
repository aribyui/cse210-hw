public class Video
{
    private string _title = "";
    private string _author = "";
    private double _length = 0;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    } 

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    } 

    public void Display()   
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Total of comments: {_comments.Count}");

        Console.WriteLine();

        int i = 0;

        foreach (Comment comment in _comments)
        {
            i++;
            Console.WriteLine($"{i}. {comment.Display()}");
        }

        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
    } 
}