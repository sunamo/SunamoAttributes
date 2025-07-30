namespace SunamoAttributes;

public class MessageIfFailAttribute : Attribute
{
    public string message;

    public MessageIfFailAttribute(string message)
    {
        this.message = message;
    }
}