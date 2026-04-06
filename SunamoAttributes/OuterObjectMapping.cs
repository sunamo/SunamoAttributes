namespace SunamoAttributes;

/// <summary>
/// Represents mapping information for an outer object, including its primary key and property information.
/// </summary>
public class OuterObjectMapping
{
    /// <summary>
    /// Gets or sets the primary key property. Note: DB can't have primary key, it's only indicator that any other element in DB is not the same as primary key.
    /// </summary>
    public PropertyInfo? PrimaryKey { get; set; } = null;

    /// <summary>
    /// Gets or sets the list of property information objects for this mapping.
    /// </summary>
    public List<PropertyInfo> PropertyInfos { get; set; } = new();
}