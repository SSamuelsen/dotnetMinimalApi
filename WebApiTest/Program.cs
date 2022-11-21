using System.Reflection;
using WebApiTest.Endpoints;
using WebApiTest.Services.Interface;
using WebApiTest.Services.Service;

var builder = WebApplication.CreateBuilder(args);

// swagger api.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// dependency injection.
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapEndpoints(Assembly.GetExecutingAssembly());
app.Run();
