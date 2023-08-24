using consoleApp;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Environment.ContentRootPath = AppContext.BaseDirectory;
builder.Services.AddHostedService<Worker>();
IHost host = builder.Build();
host.Run();

