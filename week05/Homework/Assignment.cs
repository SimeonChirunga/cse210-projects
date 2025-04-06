public class Assignment
{
    private string _studentName;
    private string _topic;
    
    
    public string getStudentName()
    {
        return _studentName;

    }
    public void setStudentName()
    {
        _studentName = "";
    }
    public string getTopic()
    {
        return _topic;

    }
    public void setTopic()
    {
        _topic = "";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetAssignmentDetails()
    {
        return $"Student: {_studentName}, Topic: {_topic}";
    }
}