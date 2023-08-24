# dotnet-templates / GenericHost

Using the Generic Host in a console app.

## Getting started

Attempting to follow along with this article: [Microsoft Generic Host](https://learn.microsoft.com/en-us/dotnet/core/extensions/generic-host).

1. Assuming the dotnet SDK is already installed, run `dotnet sdk check` to see if there are updates available.  If there are updates, follow the link to download/install.
    
2. Create a new console app from a template using `dotnet new console -o src -n consoleApp`.

3. Setup VSCode integrations, launch.json, and tasks.json.

4. Add a reference using `dotnet add src package Mircosoft.Extensions.Hosting`

## Working notes

1. Started with dotnet v7.0.203, upgraded to dotnet v7.0.400.

2. Use `dotnet new -h`, and `dotnet new list` to see what other templates are available.  You can immidiately prove that the template works using `dotnet run --project src`.

4. Use `dotnet add --help` to see how to use the command, this can be used to add references to nuget packages and to other (local) projects. 

## Packages

- [CommandLineParser](https://www.nuget.org/packages/CommandLineParser)
- [spectre.console](https://www.nuget.org/packages/Spectre.Console/0.47.1-preview.0.11)
- [spectre.console.cli](https://www.nuget.org/packages/Spectre.Console.Cli/0.47.1-preview.0.11)
- [serilog](https://www.nuget.org/packages/Serilog/3.0.2-dev-02044)
- [serilog.sinks.file](https://www.nuget.org/packages/Serilog.Sinks.File/5.0.1-dev-00947)
- [serilog.sinks.console](https://www.nuget.org/packages/Serilog.Sinks.Console/4.2.0-dev-00918)

## References

- https://learn.microsoft.com/en-us/dotnet/core/extensions/generic-host

https://learn.microsoft.com/en-us/dotnet/core/extensions/workers?pivots=dotnet-7-0

- https://learn.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/6.0/hosting-exception-handling

- https://learn.microsoft.com/en-us/dotnet/core/extensions/media/hosting-shutdown-sequence.svg#lightbox
