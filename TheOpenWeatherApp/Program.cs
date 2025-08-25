using Microsoft.Extensions.Options;
using ServiceContract;
using Services;
using Services.Providers.OpenWeather;

var builder = WebApplication.CreateBuilder(args);

//Register dependencies for MVC app
builder.Services.AddControllersWithViews();

//Register WeatherApi section Options
builder.Services.Configure<WeatherApiOptions>(builder.Configuration.GetSection("WeatherApi"));

//Inject dependencies using ASP.NET Core built-in IoC container
builder.Services.AddScoped<ICitiesService, CitiesService>();

builder.Services.AddHttpClient<IWeatherService, WeatherService>(
    (sp, http) =>
    {
        var options = sp.GetRequiredService<IOptions<WeatherApiOptions>>().Value;
        http.BaseAddress = new Uri(options.BaseUrl);
        http.Timeout = TimeSpan.FromSeconds(options.TimeoutSeconds);
    }
    );

var app = builder.Build();

//Enable static files in wwwroot folder
app.UseStaticFiles();
//Enable routing middleware that matches incoming requests to a controller/view (ASP.NET 3.0+)
app.UseRouting();
//Look for the controllers routes defined by attributes and map them as endpoints
app.MapControllers();


app.Run();
