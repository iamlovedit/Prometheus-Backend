using Prometheus.Backend.Domain.Entities;
using Prometheus.Backend.Services;
using Roller.Infrastructure.SetupExtensions;
using Roller.Infrastructure.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddScoped<IDatabaseService, DatabaseService>();
services.AddScoped<IProductionService, ProductionService>();
services.AddScoped<IVersionService, VersionService>();
services.AddHttpContextAccessor();
builder.AddInfrastructureSetup();

var app = builder.Build();

app.UseInfrastructure();