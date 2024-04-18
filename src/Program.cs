using Roller.Infrastructure.SetupExtensions;
using Roller.Infrastructure.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

builder.AddInfrastructureSetup();

var app = builder.Build();

app.UseInfrastructure();