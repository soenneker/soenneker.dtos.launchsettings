using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.LaunchSettings;

/// <summary>
/// Represents the root structure of a launchSettings.json file used by .NET projects.
/// </summary>
public sealed class LaunchSettings
{
    /// <summary>
    /// A dictionary of launch profiles, where the key is the profile name.
    /// </summary>
    [JsonPropertyName("profiles")]
    public Dictionary<string, LaunchProfile> Profiles { get; set; } = [];

    /// <summary>
    /// Optional IIS settings used during development when targeting IIS Express.
    /// </summary>
    [JsonPropertyName("iisSettings")]
    public IisSettings? IisSettings { get; set; }

    /// <summary>
    /// Optional schema URL reference for validation tools.
    /// </summary>
    [JsonPropertyName("$schema")]
    public string? Schema { get; set; }
}