[![](https://img.shields.io/nuget/v/soenneker.dtos.launchsettings.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.launchsettings/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.launchsettings/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.launchsettings/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.launchsettings.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.launchsettings/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.launchsettings/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.launchsettings/actions/workflows/codeql.yml)

# Soenneker.Dtos.LaunchSettings

Configuration for IIS Express hosting.

## Install

```bash
dotnet add package Soenneker.Dtos.LaunchSettings
```

## What you get

- `IisExpressSettings` — Configuration for IIS Express hosting.
- `IisSettings` — Represents IIS-specific settings for development.
- `LaunchProfile` — Represents a single launch profile for the application.
- `LaunchSettings` — Represents the root structure of a launchSettings.json file used by .NET projects.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `IisExpressSettings.ApplicationUrl` | The URL where the application is hosted by IIS Express. | The URL where the application is hosted by IIS Express. |
| `IisExpressSettings.SslPort` | The SSL port used by IIS Express. | The SSL port used by IIS Express. |
| `IisSettings.WindowsAuthentication` | Whether Windows Authentication is enabled for the IIS Express profile. | Whether Windows Authentication is enabled for the IIS Express profile. |
| `IisSettings.AnonymousAuthentication` | Whether Anonymous Authentication is enabled for the IIS Express profile. | Whether Anonymous Authentication is enabled for the IIS Express profile. |
| `IisSettings.IisExpress` | Configuration settings for IIS Express. | Configuration settings for IIS Express. |
| `LaunchProfile.CommandName` | The command to run (e.g., Project, IISExpress, Executable). | The command to run (e.g., Project, IISExpress, Executable). |
| `LaunchProfile.DotnetRunMessages` | If true, enables .NET CLI run messages when using 'dotnet run'. | If true, enables .NET CLI run messages when using 'dotnet run'. |
| `LaunchProfile.LaunchBrowser` | Indicates whether the browser should be launched automatically. | Indicates whether the browser should be launched automatically. |
| `LaunchProfile.LaunchUrl` | The URL to launch in the browser when the application starts. | The URL to launch in the browser when the application starts. |
| `LaunchProfile.ApplicationUrl` | The base URL where the application will be hosted. | The base URL where the application will be hosted. |
| `LaunchProfile.EnvironmentVariables` | A collection of environment variables to set for the launch profile. | A collection of environment variables to set for the launch profile. |
| `LaunchProfile.InspectUri` | The URI used for debugging inspection (typically for Node.js or browser-based debugging). | The URI used for debugging inspection (typically for Node.js or browser-based debugging). |
| `LaunchProfile.WorkingDirectory` | The working directory for the application when launched. | The working directory for the application when launched. |
| `LaunchProfile.CommandLineArgs` | Additional command-line arguments passed to the application. | Additional command-line arguments passed to the application. |
| `LaunchProfile.NativeDebugging` | Indicates whether native debugging is enabled (for unmanaged code). | Indicates whether native debugging is enabled (for unmanaged code). |
| `LaunchProfile.Port` | Gets or sets the port number used by the application (not serialized). | Gets or sets the port number used by the application (not serialized). |
| `LaunchSettings.Profiles` | A dictionary of launch profiles, where the key is the profile name. | A dictionary of launch profiles, where the key is the profile name. |
| `LaunchSettings.IisSettings` | Optional IIS settings used during development when targeting IIS Express. | Optional IIS settings used during development when targeting IIS Express. |
