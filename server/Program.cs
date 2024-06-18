var allowSpecificOrigins = "default";

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => {
    options.AddPolicy(name: allowSpecificOrigins, policy => {
        policy.WithOrigins("*");
        });
    });

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseCors(allowSpecificOrigins);

app.Run();
