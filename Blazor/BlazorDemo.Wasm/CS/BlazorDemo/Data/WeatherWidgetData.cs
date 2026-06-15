using System;
using System.Collections.Generic;

namespace BlazorDemo.Data {
    public sealed class WeatherWidgetData {
        public string CityName { get; set; }
        public string Country { get; set; }
        public double Temperature { get; set; }
        public double FeelsLike { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int Humidity { get; set; }
        public double WindSpeed { get; set; }
        public int Pressure { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        public List<DailyForecast> FiveDayForecast { get; set; } = new List<DailyForecast>();
    }

    public sealed class DailyForecast {
        public DateTime Date { get; set; }
        public double MaxTemp { get; set; }
        public double MinTemp { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int Humidity { get; set; }
    }
}
