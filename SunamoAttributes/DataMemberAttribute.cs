namespace SunamoAttributes;

/// <summary>
/// Represents the data member attribute type.
/// </summary>
public class DataMemberAttribute : Attribute
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Data member attribute.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns>The data member attribute result.</returns>
    public DataMemberAttribute(string name)
    {
        Name = name;
    }
}
