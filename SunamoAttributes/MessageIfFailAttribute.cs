namespace SunamoAttributes;

/// <summary>
/// Attribute to specify a custom error message to be displayed if validation or operation fails.
/// </summary>
public class MessageIfFailAttribute : Attribute
{
    /// <summary>
    /// Gets or sets the error message to be displayed on failure.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MessageIfFailAttribute"/> class with the specified error message.
    /// </summary>
    /// <param name="message">The error message to display on failure.</param>
    public MessageIfFailAttribute(string message)
    {
        Message = message;
    }
}