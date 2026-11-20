namespace SunamoAttributes;

/// <summary>
/// Represents the message if fail attribute type.
/// </summary>
public class MessageIfFailAttribute : Attribute
{
    /// <summary>
    /// Gets or sets the message.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Message if fail attribute.
    /// </summary>
    /// <param name="message">The message.</param>
    /// <returns>The message if fail attribute result.</returns>
    public MessageIfFailAttribute(string message)
    {
        Message = message;
    }
}
