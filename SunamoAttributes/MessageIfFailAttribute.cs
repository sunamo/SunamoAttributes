namespace SunamoAttributes;

/// <summary>
/// EN: Attribute to specify a custom error message to be displayed if validation or operation fails.
/// CZ: Atribut pro specifikaci vlastní chybové zprávy, která se zobrazí v případě selhání validace nebo operace.
/// </summary>
public class MessageIfFailAttribute : Attribute
{
    /// <summary>
    /// EN: Gets or sets the error message to be displayed on failure.
    /// CZ: Získává nebo nastavuje chybovou zprávu, která se zobrazí při selhání.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// EN: Initializes a new instance of the MessageIfFailAttribute class with the specified error message.
    /// CZ: Inicializuje novou instanci třídy MessageIfFailAttribute se zadanou chybovou zprávou.
    /// </summary>
    /// <param name="message">EN: The error message to display on failure. CZ: Chybová zpráva, která se zobrazí při selhání.</param>
    public MessageIfFailAttribute(string message)
    {
        Message = message;
    }
}
