using System;
public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetTopic()
    {
        return _topic;
    }
    
    public string GetName()
    {
        return _studentName;
    }
}