namespace SunamoAttributes;

/// <summary>
/// EN: Attribute to specify the name of a data member for serialization or mapping purposes.
/// CZ: Atribut pro specifikaci názvu datového člena pro účely serializace nebo mapování.
/// </summary>
public class DataMemberAttribute : Attribute
{
    /// <summary>
    /// EN: Gets or sets the name of the data member.
    /// CZ: Získává nebo nastavuje název datového člena.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// EN: Initializes a new instance of the DataMemberAttribute class with the specified name.
    /// CZ: Inicializuje novou instanci třídy DataMemberAttribute se zadaným názvem.
    /// </summary>
    /// <param name="name">EN: The name of the data member. CZ: Název datového člena.</param>
    public DataMemberAttribute(string name)
    {
        Name = name;
    }
}