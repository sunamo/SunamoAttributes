// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoAttributes;

public class MessageIfFailAttribute : Attribute
{
    public string message;

    public MessageIfFailAttribute(string message)
    {
        this.message = message;
    }
}