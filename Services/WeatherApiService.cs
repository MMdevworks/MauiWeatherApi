using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// handle api calls and integration
namespace MauiWeatherApi.Services;
internal class WeatherApiService
{
    // instantiate once and use throughout app
    private readonly HttpClient _httpClient;

    public WeatherApiService()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri(Constants.API_BASE_URL);
    }
}


