// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoAttributes;

public class DataMemberAttribute : Attribute
{
    public string Name;

    public DataMemberAttribute(string Name)
    {
        this.Name = Name;
    }
}