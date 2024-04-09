using Prometheus.Backend.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

builder.AddInfrastructureSetup();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();