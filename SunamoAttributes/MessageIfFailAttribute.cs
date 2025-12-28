// variables names: ok
namespace SunamoAttributes;

public class MessageIfFailAttribute : Attribute
{
    public string Message;

    public MessageIfFailAttribute(string message)
    {
        Message = message;
    }
}