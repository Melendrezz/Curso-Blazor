using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor5dotnet.Models;


namespace blazor5dotnet.Service
{
    public interface IWeatherForecastService
    {
        
       internal Task<WeatherForecast[]> Get();
    }
    
}