//Student student = new Student();
//student.AddstudentRecord();
using System.Runtime.Serialization;

[Serializable]
internal class InvalidFeeException : Exception
{
    public InvalidFeeException()
    {
    }

    public InvalidFeeException(string message) : base(message)
    {
    }

    public InvalidFeeException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected InvalidFeeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}