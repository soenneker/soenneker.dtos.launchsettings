[![](https://img.shields.io/nuget/v/soenneker.dtos.launchsettings.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.launchsettings/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.launchsettings/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.launchsettings/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.launchsettings.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.launchsettings/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.launchsettings/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.launchsettings/actions/workflows/codeql.yml)

# Soenneker.Dtos.LaunchSettings

Typed `System.Text.Json` models for reading and writing a .NET project's `Properties/launchSettings.json` file.

## Install

```bash
dotnet add package Soenneker.Dtos.LaunchSettings
```

## Read launch settings

```csharp
using System.Text.Json;
using System.Text.Json.Serialization;
using Soenneker.Dtos.LaunchSettings;

string json = await File.ReadAllTextAsync("Properties/launchSettings.json");

LaunchSettings? settings = JsonSerializer.Deserialize<LaunchSettings>(json);

if (settings?.Profiles.TryGetValue("https", out LaunchProfile? profile) == true)
{
    Console.WriteLine(profile.ApplicationUrl);
    Console.WriteLine(profile.EnvironmentVariables["ASPNETCORE_ENVIRONMENT"]);
}
```

## Create or update a profile

```csharp
var settings = new LaunchSettings();

settings.Profiles["Worker"] = new LaunchProfile
{
    CommandName = "Project",
    DotnetRunMessages = true,
    EnvironmentVariables =
    {
        ["DOTNET_ENVIRONMENT"] = "Development"
    }
};

string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions
{
    WriteIndented = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
});
```

`Profiles` and each profile's `EnvironmentVariables` dictionary are initialized automatically. Optional members remain `null` when absent. `LaunchProfile.Port` is an application-only convenience property marked with `[JsonIgnore]`; it is never read from or written to `launchSettings.json`.
