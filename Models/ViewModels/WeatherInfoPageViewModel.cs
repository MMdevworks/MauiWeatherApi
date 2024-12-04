using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWeatherApi.Models.ViewModels
{
    internal partial class WeatherInfoPageViewModel:ObservableObject
    {
        [ObservableProperty]
        private string latitude;

        [ObservableProperty]
        private string longitude;

        [ObservableProperty]
        private string weatherIcon;

        [ObservableProperty]
        private string temperature;

        [ObservableProperty]
        private string weatherDescription;

        [ObservableProperty]
        private string location;

        [ObservableProperty]
        private int humidity;

        [ObservableProperty]
        private string cloudCoverLevel;

        [ObservableProperty]
        private string isDay;

        [RelayCommand]
        private async Task FetchWeatherInfo()
        {

        }
    }
}
