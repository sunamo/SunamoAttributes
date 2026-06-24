namespace SunamoAttributes;

public class DataMemberAttribute : Attribute
{
    public string Name { get; set; }

    public DataMemberAttribute(string name)
    {
        Name = name;
    }
}
