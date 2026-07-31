namespace Homework;

public class MathAssignment : Assignment
{
    private string _textBookSession;

    private string _problems;
    public MathAssignment(string studentName, string topic, string textBookSession, string problems) : base(studentName, topic)
    {
        _textBookSession = textBookSession;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textBookSession}, Problems: {_problems}";
    }


}