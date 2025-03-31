using System.Text.Json.Serialization;

namespace Soenneker.Dtos.LaunchSettings;

/// <summary>
/// Represents IIS-specific settings for development.
/// </summary>
public class IisSettings
{
    /// <summary>
    /// Whether Windows Authentication is enabled for the IIS Express profile.
    /// </summary>
    [JsonPropertyName("windowsAuthentication")]
    public bool? WindowsAuthentication { get; set; }

    /// <summary>
    /// Whether Anonymous Authentication is enabled for the IIS Express profile.
    /// </summary>
    [JsonPropertyName("anonymousAuthentication")]
    public bool? AnonymousAuthentication { get; set; }

    /// <summary>
    /// Configuration settings for IIS Express.
    /// </summary>
    [JsonPropertyName("iisExpress")]
    public IisExpressSettings? IisExpress { get; set; }
}