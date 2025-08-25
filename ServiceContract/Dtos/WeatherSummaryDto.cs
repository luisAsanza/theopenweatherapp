using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ServiceContract.Dtos
{
    public class WeatherSummaryDto
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public DateTimeOffset TimeZone { get; set; }
        public DateOnly Date { get; set; }
        public string Units { get; set; }
        public HumidityDto Humidity { get; set; }
        public TemperatureDto Temperature { get; set; }
    }
}
