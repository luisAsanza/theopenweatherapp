var builder = WebApplication.CreateBuilder(args);

//Register dependencies for MVC app
builder.Services.AddControllersWithViews();

//Inject dependencies using ASP.NET Core built-in IoC container


var app = builder.Build();

//Enable static files in wwwroot folder
app.UseStaticFiles();
//Enable routing middleware that matches incoming requests to a controller/view (ASP.NET 3.0+)
app.UseRouting();
//Look for the controllers routes defined by attributes and map them as endpoints
app.MapControllers();


app.Run();
