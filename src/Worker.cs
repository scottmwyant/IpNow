namespace consoleApp;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IHostApplicationLifetime _appLifetime;

    public Worker(ILogger<Worker> logger, IHostApplicationLifetime appLifetime)
    {
        _appLifetime = appLifetime;
        _logger = logger;
        appLifetime.ApplicationStarted.Register(()=> _logger.LogInformation("2. OnStarted has been called."));
        appLifetime.ApplicationStopping.Register(()=> _logger.LogInformation("3. OnStopping has been called."));
        appLifetime.ApplicationStopped.Register(()=> _logger.LogInformation("5. OnStopped has been called."));
    }

    public override async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("1. StartAsync has been called.");
        await base.StartAsync(cancellationToken);
    }

    public override async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("4. StopAsync has been called.");
        await base.StopAsync(cancellationToken);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("1b. ExecuteAsync has been called.");
        var i = 0; 
        while (!stoppingToken.IsCancellationRequested && i < 2)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
            i++;
        }
        _appLifetime.StopApplication();
    }
}
