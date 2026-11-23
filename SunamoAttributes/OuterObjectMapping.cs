namespace SunamoAttributes;

/// <summary>
/// Represents the outer object mapping type.
/// </summary>
public class OuterObjectMapping
{
    /// <summary>
    /// Gets or sets the primary key.
    /// </summary>
    public PropertyInfo? PrimaryKey { get; set; } = null;

    /// <summary>
    /// Gets or sets the property infos.
    /// </summary>
    public List<PropertyInfo> PropertyInfos { get; set; } = new();
}
