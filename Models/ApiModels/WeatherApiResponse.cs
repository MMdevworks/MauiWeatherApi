using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MauiWeatherApi.Models.ApiModels
{
    class WeatherApiResponse
    {
        [JsonPropertyName("request")]
        public WeatherApiResponseRequest request { get; set; }
        [JsonPropertyName("location")]
        public WeatherApiResponseLocation location { get; set; }
        [JsonPropertyName("current")]
        public WeatherApiResponseCurrent current { get; set; }
    }

    public class WeatherApiResponseRequest
    {
        [JsonPropertyName("type")]
        public string type { get; set; }
        [JsonPropertyName("query")]
        public string query { get; set; }
        [JsonPropertyName("language")]
        public string language { get; set; }
        [JsonPropertyName("unit")]
        public string unit { get; set; }
    }

    public class WeatherApiResponseLocation
    {
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("country")]
        public string country { get; set; }
        [JsonPropertyName("region")]
        public string region { get; set; }
        [JsonPropertyName("lat")]
        public string lat { get; set; }
        [JsonPropertyName("lon")]
        public string lon { get; set; }
        [JsonPropertyName("timezone_id")]
        public string timezone_id { get; set; }
        [JsonPropertyName("localtime")]
        public string localtime { get; set; }
        [JsonPropertyName("localtime_epoch")]
        public int localtime_epoch { get; set; }
        [JsonPropertyName("utc_offset")]
        public string utc_offset { get; set; }
    }

    public class WeatherApiResponseCurrent
    {
        [JsonPropertyName("observation_time")]
        public string observation_time { get; set; }
        [JsonPropertyName("temperature")]
        public int temperature { get; set; }
        [JsonPropertyName("weather_code")]
        public int weather_code { get; set; }
        [JsonPropertyName("weather_icons")]
        public string[] weather_icons { get; set; }
        [JsonPropertyName("weather_descriptions")]
        public string[] weather_descriptions { get; set; }
        [JsonPropertyName("wind_speed")]
        public int wind_speed { get; set; }
        [JsonPropertyName("wind_degree")]
        public int wind_degree { get; set; }
        [JsonPropertyName("wind_dir")]
        public string wind_dir { get; set; }
        [JsonPropertyName("pressure")]
        public int pressure { get; set; }
        [JsonPropertyName("precip")]
        public int precip { get; set; }
        [JsonPropertyName("humidity")]
        public int humidity { get; set; }
        [JsonPropertyName("cloudcover")]
        public int cloudcover { get; set; }
        [JsonPropertyName("feelslike")]
        public int feelslike { get; set; }
        [JsonPropertyName("uv_index")]
        public int uv_index { get; set; }
        [JsonPropertyName("visibility")]
        public int visibility { get; set; }
        [JsonPropertyName("is_day")]
        public string is_day { get; set; }
    }

}

