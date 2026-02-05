namespace DailyDoseOfAi.Core;

/// <summary>
/// Represents a user profile with identification and role information.
/// </summary>
public class JfUserProfile
{
    /// <summary>
    /// Gets or sets the user's first name (Praenomen).
    /// </summary>
    public string Praenomen { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the user's last name (Cognomen).
    /// </summary>
    public string Cognomen { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the user's email address.
    /// </summary>
    public string Epistola { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the array of roles assigned to the user.
    /// </summary>
    public string[] Munera { get; set; } = Array.Empty<string>();

    /// <summary>
    /// Gets or sets the user's country (Patria).
    /// </summary>
    public string Patria { get; set; } = string.Empty;
}
