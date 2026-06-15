using System.ComponentModel;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorDemo.Services;
using Microsoft.Extensions.AI;

namespace BlazorDemo.Agents.Weather {
    public class WeatherAgentTools {
        readonly WeatherService weatherService;

        public WeatherAgentTools(WeatherService weatherService) {
            this.weatherService = weatherService;
        }

        public AIFunction GetWeatherTool()
            => AIFunctionFactory.Create(GetWeather, "GetWeather",
                "Returns the current weather and 5-day forecast for a specified city as JSON.");

        [Description("Gets current weather and 5-day forecast for a specified city. Returns a beautifully formatted weather widget with temperature, humidity, wind speed, and daily forecasts.")]
        async Task<string> GetWeather(
            [Description("The name of the city to get weather for (e.g., 'London', 'New York', 'Tokyo')")] string cityName) {

            var weather = await weatherService.GetWeatherAsync(cityName).ConfigureAwait(false);

            if(weather == null)
                return $"Sorry, I couldn't fetch weather data for '{cityName}'. Please check the city name and try again.";

            return JsonSerializer.Serialize(weather, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
