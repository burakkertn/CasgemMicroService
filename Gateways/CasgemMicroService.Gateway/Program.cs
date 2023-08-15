using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("Configuration.Developent.json", optional: false);

builder.Services.AddOcelot();
builder.Services.AddAuthentication().AddJwtBearer("GatewayAuthenticationScheme", opt =>
{
    opt.Authority = builder.Configuration["IdentityServerUrl"];
    opt.Audience = "resource_gateway";
    opt.RequireHttpsMetadata = false;
});


var app = builder.Build();

app.MapGet("/", () => "Hello World!");
await app.UseOcelot();
app.Run();