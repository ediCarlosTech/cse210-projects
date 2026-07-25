public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSecond;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSecond)
    {
        _title = title;
        _author = author;
        _lengthInSecond = lengthInSecond;
    }

    public int GetCommentsQuantity()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string GetVideoDetails()
    {
        string videoDetail = $"Video Title: {_title}, Author: {_author}, Length (in seconds): {_lengthInSecond}, Number of Comments: {GetCommentsQuantity()}\n";

        videoDetail += "\nHere are the comments of the video:\n\n";

        foreach (Comment comment in _comments)
        {
            videoDetail += $"{comment.GetComment()}\n";
        }

        return videoDetail;
    }
}