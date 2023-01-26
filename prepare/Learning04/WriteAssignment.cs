using System;

class WriteAssignment : Assignment
{
    private string _title;

    public WriteAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
    public string GetWritingInfo()
    {
        string writingInfo = $"{_title} by {_studentName}";
        return writingInfo;
    }
}