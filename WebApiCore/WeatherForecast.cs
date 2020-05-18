using System;
using System.Collections.Generic;

namespace WebApiCore
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class Hosts
    {
        public string Hostid { get; set; }
        public List<WeatherForecast> WeatherForecasts { get; set; }
    }
}
