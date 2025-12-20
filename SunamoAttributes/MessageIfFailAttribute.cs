// variables names: ok
// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoAttributes;

public class MessageIfFailAttribute : Attribute
{
    public string Message;

    public MessageIfFailAttribute(string message)
    {
        Message = message;
    }
}