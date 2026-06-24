namespace SunamoAttributes;

public class MessageIfFailAttribute : Attribute
{
    public string Message { get; set; }

    public MessageIfFailAttribute(string message)
    {
        Message = message;
    }
}
