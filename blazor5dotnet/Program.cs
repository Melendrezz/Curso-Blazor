using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using blazor5dotnet;
using blazor5dotnet.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using blazor5dotnet.Service;
using Blazored.Toast;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Logging.SetMinimumLevel(LogLevel.Debug);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IWeatherForecastService, WeatherForeCastService>();
builder.Services.AddBlazoredToast();

//para conservar datos en la ram al cambiar de componente
builder.Services.AddScoped(sp => new CounterViewModel()); 
//Para no conservar datos en la ram al cambiar de compoente
//builder.Services.AddTransient(sp => new CounterViewModel());


await builder.Build().RunAsync();
