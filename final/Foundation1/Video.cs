using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments; 

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

        _comments = new List<Comment>();
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public string DisplayVideo()
    {
        return $"Title: {_title}, Author: {_author}, Video Length: {_length} seconds, # of Comments: {GetCommentCount()}\n";
    }

    public void DisplayComment()
    {
        foreach(Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayComment());
        }
    }
}