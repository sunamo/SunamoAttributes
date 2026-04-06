namespace SunamoAttributes;

/// <summary>
/// Attribute to specify the name of a data member for serialization or mapping purposes.
/// </summary>
public class DataMemberAttribute : Attribute
{
    /// <summary>
    /// Gets or sets the name of the data member.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataMemberAttribute"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the data member.</param>
    public DataMemberAttribute(string name)
    {
        Name = name;
    }
}