# dotnet-templates / ConsoleApp

Write a console app using the Generic Host.

## Getting started

Following along with this article: [Microsoft Generic Host](https://learn.microsoft.com/en-us/dotnet/core/extensions/generic-host).

1. I assume the dotnet SDK is already installed.  Run `dotnet --version` or run `dotnet sdk check` to see if there are updates available.  If there are updates, follow the link to download/install.
    
2. Create a new console app from a template using `dotnet new console -o src -n consoleApp`.

3. Setup VSCode integrations, launch.json, and tasks.json.

4. Add a reference using `dotnet add src package Mircosoft.Extensions.Hosting`

## Working notes

1. Started with dotnet v7.0.203, upgraded to dotnet v7.0.400.

2. Use `dotnet new -h`, and `dotnet new list` to see what other templates are available.  After you create a new console app, you can immidiately prove that the template works using `dotnet run src`.

4. Use `dotnet add --help` to see how to use the command, this can be used to add references to nuget packages and to other (local) projects. 

## Key concepts seen in 'Generic Host'

The framework is used like this:

1. Create and configure a 'builder' object.  Generally, "configure the builder" means making it aware of specific details define a few major aspects of how your app runs (i.e. configuration, logging).
    
    - Configuring the builder usees a lot of extension methods, if you're not finding a method that you see in documentation, you're probably missing a dependency.

    - Configuring the builder means telling it how your app will be provided it's runtime configuration, how logging will work, and registering services (the classes you implement, your custom code).

    - Services are registered as either `Hosted`, `Singleton`, `Transient`, or `Scoped`.
        
        - Lifetime of *Hosted* services match lifetime of the application; when the application starts, the hosted service starts.

        - Lifetime of *Singleton* services is a bit different; a singleton service is instantiated the first time it's needed as opposed to when the app starts.  The way it's instantiated is different from a Hosted service, but the way it's disposed is not; once instantiated, a Singleton service will exist for the lifetime of the application.

        - *Scoped* services will typically have the shortest lifetime, but really doesn't make sense to use in context of a console app.  It would be possible to implement some idea of a scope, but this type of service, is typically reserved for web applications, where the lifetime would match the lifetime of the session scope (of the HTTP request).

2. Register a Hosted service
    
    - You need to have at least one *Hosted* service, that is, one service that the framework will start immidiately after the application starts.

3. Build and run the host.

## Packages

- [CommandLineParser](https://www.nuget.org/packages/CommandLineParser)
- [spectre.console](https://www.nuget.org/packages/Spectre.Console/0.47.1-preview.0.11)
- [spectre.console.cli](https://www.nuget.org/packages/Spectre.Console.Cli/0.47.1-preview.0.11)
- [serilog](https://www.nuget.org/packages/Serilog/3.0.2-dev-02044)
- [serilog.sinks.file](https://www.nuget.org/packages/Serilog.Sinks.File/5.0.1-dev-00947)
- [serilog.sinks.console](https://www.nuget.org/packages/Serilog.Sinks.Console/4.2.0-dev-00918)

## References

- https://learn.microsoft.com/en-us/dotnet/core/extensions/generic-host

- https://learn.microsoft.com/en-us/dotnet/core/extensions/workers?pivots=dotnet-7-0

- https://learn.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/6.0/hosting-exception-handling

- https://learn.microsoft.com/en-us/dotnet/core/extensions/media/hosting-shutdown-sequence.svg#lightbox
