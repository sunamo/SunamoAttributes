namespace SunamoAttributes;

public class OuterObjectMapping
{
    public PropertyInfo? PrimaryKey { get; set; } = null;

    public List<PropertyInfo> PropertyInfos { get; set; } = new();
}
