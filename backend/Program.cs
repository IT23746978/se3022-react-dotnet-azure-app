var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReact",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseCors("AllowReact");

app.MapGet("/weatherforecast", () =>
{
    var data = new[]
    {
        new { date = "2026-03-20", temperatureC = 28, summary = "Warm" },
        new { date = "2026-03-21", temperatureC = 30, summary = "Hot" },
        new { date = "2026-03-22", temperatureC = 27, summary = "Cloudy" }
    };

    return Results.Ok(data);
});

app.Run();