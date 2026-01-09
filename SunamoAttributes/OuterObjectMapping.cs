// variables names: ok
namespace SunamoAttributes;

/// <summary>
/// EN: Represents mapping information for an outer object, including its primary key and property information.
/// CZ: Reprezentuje informace o mapování vnějšího objektu, včetně jeho primárního klíče a informací o vlastnostech.
/// </summary>
public class OuterObjectMapping
{
    /// <summary>
    /// EN: Gets or sets the primary key property. Note: DB can't have primary key, it's only indicator that any other element in DB is not the same as primary key.
    /// CZ: Získává nebo nastavuje vlastnost primárního klíče. Poznámka: DB nemůže mít primární klíč, je to pouze indikátor, že žádný jiný prvek v DB není stejný jako primární klíč.
    /// </summary>
    public PropertyInfo? PrimaryKey { get; set; } = null;

    /// <summary>
    /// EN: Gets or sets the list of property information objects for this mapping.
    /// CZ: Získává nebo nastavuje seznam objektů s informacemi o vlastnostech pro toto mapování.
    /// </summary>
    public List<PropertyInfo> PropertyInfos { get; set; } = new();
}