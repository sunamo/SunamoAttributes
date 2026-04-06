namespace SunamoAttributes;

/// <summary>
/// Represents mapping information for an outer object, including its primary key and property information.
/// </summary>
public class OuterObjectMapping
{
    /// <summary>
    /// Gets or sets the primary key property. Used as an indicator that distinguishes records in the database, not an actual database primary key constraint.
    /// </summary>
    public PropertyInfo? PrimaryKey { get; set; } = null;

    /// <summary>
    /// Gets or sets the list of property information objects for this mapping.
    /// </summary>
    public List<PropertyInfo> PropertyInfos { get; set; } = new();
}