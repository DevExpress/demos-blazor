using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;
using DevExpress.Data.Utils;

namespace BlazorDemo.Services {
    public class WeatherService {
        static readonly string[] Descriptions = ["clear sky", "few clouds", "scattered clouds", "broken clouds", "shower rain", "rain", "thunderstorm", "snow", "mist"];
        static readonly string[] Icons = ["01d", "02d", "03d", "04d", "09d", "10d", "11d", "13d", "50d"];
        static readonly string[] Countries = ["GB", "US", "JP", "FR", "DE", "AU", "CA", "IT", "ES", "BR"];

        public Task<WeatherWidgetData> GetWeatherAsync(string cityName) {
            int descIndex = TutorialConstants.Random.Next(Descriptions.Length);
            double temp = Math.Round(TutorialConstants.Random.NextDouble() * 40 - 5, 1);
            var now = DateTime.Now;

            var forecast = new List<DailyForecast>();
            for(int i = 0; i < 5; i++) {
                int fi = TutorialConstants.Random.Next(Descriptions.Length);
                double hi = Math.Round(temp + TutorialConstants.Random.NextDouble() * 8, 1);
                double lo = Math.Round(temp - TutorialConstants.Random.NextDouble() * 8, 1);
                forecast.Add(new DailyForecast {
                    Date = now.AddDays(i),
                    MaxTemp = hi,
                    MinTemp = lo,
                    Description = Descriptions[fi],
                    Icon = Icons[fi],
                    Humidity = TutorialConstants.Random.Next(30, 95)
                });
            }

            var result = new WeatherWidgetData {
                CityName = cityName,
                Country = Countries[TutorialConstants.Random.Next(Countries.Length)],
                Temperature = temp,
                FeelsLike = Math.Round(temp + TutorialConstants.Random.NextDouble() * 4 - 2, 1),
                Description = Descriptions[descIndex],
                Icon = Icons[descIndex],
                Humidity = TutorialConstants.Random.Next(30, 95),
                WindSpeed = Math.Round(TutorialConstants.Random.NextDouble() * 15, 1),
                Pressure = TutorialConstants.Random.Next(990, 1040),
                Sunrise = now.Date.AddHours(5 + TutorialConstants.Random.NextDouble() * 2),
                Sunset = now.Date.AddHours(18 + TutorialConstants.Random.NextDouble() * 2),
                FiveDayForecast = forecast
            };

            return Task.FromResult(result);
        }
    }

    public static class TutorialConstants {
        static DateTime fieldNow = DateTime.Now;

        static NonCryptographicRandom rnd = NonCryptographicRandom.System;

        public static void CreateConstants(DateTime dt, NonCryptographicRandom specificRandom) {
            fieldNow = dt;
            rnd = specificRandom;
        }

        public static DateTime Now => fieldNow;
        public static DateTime Today => fieldNow.Date;
        public static NonCryptographicRandom Random => rnd;
    }
}
