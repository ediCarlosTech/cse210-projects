public class Comment
{
    private string _commenter;
    private string _commentText;

    public Comment(string commenter, string commentText)
    {
        _commenter = commenter;
        _commentText = commentText;
    }

    public string GetComment()
    {
        return _commentText;
    }
}