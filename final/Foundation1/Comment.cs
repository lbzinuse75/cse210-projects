public class Comment
{
    public string _name;
    public string _commentText;

    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }

    public string DisplayComment()
    {
        return $"     Name: {_name}: Comment: {_commentText}";
    }

}