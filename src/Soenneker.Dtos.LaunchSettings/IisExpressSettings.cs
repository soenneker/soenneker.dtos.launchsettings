using System.Text.Json.Serialization;

namespace Soenneker.Dtos.LaunchSettings;

/// <summary>
/// Configuration for IIS Express hosting.
/// </summary>
public sealed class IisExpressSettings
{
    /// <summary>
    /// The URL where the application is hosted by IIS Express.
    /// </summary>
    [JsonPropertyName("applicationUrl")]
    public string? ApplicationUrl { get; set; }

    /// <summary>
    /// The SSL port used by IIS Express.
    /// </summary>
    [JsonPropertyName("sslPort")]
    public int? SslPort { get; set; }
}