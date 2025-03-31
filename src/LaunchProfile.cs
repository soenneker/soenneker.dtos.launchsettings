using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.LaunchSettings;

/// <summary>
/// Represents a single launch profile for the application.
/// </summary>
public class LaunchProfile
{
    /// <summary>
    /// The command to run (e.g., Project, IISExpress, Executable).
    /// </summary>
    [JsonPropertyName("commandName")]
    public string? CommandName { get; set; }

    /// <summary>
    /// If true, enables .NET CLI run messages when using 'dotnet run'.
    /// </summary>
    [JsonPropertyName("dotnetRunMessages")]
    public bool? DotnetRunMessages { get; set; }

    /// <summary>
    /// Indicates whether the browser should be launched automatically.
    /// </summary>
    [JsonPropertyName("launchBrowser")]
    public bool? LaunchBrowser { get; set; }

    /// <summary>
    /// The URL to launch in the browser when the application starts.
    /// </summary>
    [JsonPropertyName("launchUrl")]
    public string? LaunchUrl { get; set; }

    /// <summary>
    /// The base URL where the application will be hosted.
    /// </summary>
    [JsonPropertyName("applicationUrl")]
    public string? ApplicationUrl { get; set; }

    /// <summary>
    /// A collection of environment variables to set for the launch profile.
    /// </summary>
    [JsonPropertyName("environmentVariables")]
    public Dictionary<string, string> EnvironmentVariables { get; set; } = [];

    /// <summary>
    /// The URI used for debugging inspection (typically for Node.js or browser-based debugging).
    /// </summary>
    [JsonPropertyName("inspectUri")]
    public string? InspectUri { get; set; }

    /// <summary>
    /// The working directory for the application when launched.
    /// </summary>
    [JsonPropertyName("workingDirectory")]
    public string? WorkingDirectory { get; set; }

    /// <summary>
    /// Additional command-line arguments passed to the application.
    /// </summary>
    [JsonPropertyName("commandLineArgs")]
    public string? CommandLineArgs { get; set; }

    /// <summary>
    /// Indicates whether native debugging is enabled (for unmanaged code).
    /// </summary>
    [JsonPropertyName("nativeDebugging")]
    public bool? NativeDebugging { get; set; }

    /// <summary>
    /// Gets or sets the port number used by the application (not serialized).
    /// </summary>
    [JsonIgnore]
    public int Port { get; set; }
}