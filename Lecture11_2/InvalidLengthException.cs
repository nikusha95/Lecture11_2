namespace Lecture11_2;

public class InvalidLengthException : Exception
{
    private string _info;
    public string Info => _info;

    public InvalidLengthException(string message, string info) : base(message)
    {
        _info = info;
    }

    public InvalidLengthException(string message, Exception innerException, string info)
        : base(message, innerException)
    {
        _info = info;
    }
}