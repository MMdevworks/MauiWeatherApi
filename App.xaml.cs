using MauiWeatherApi.Pages;

namespace MauiWeatherApi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new WeatherInfoPage();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}