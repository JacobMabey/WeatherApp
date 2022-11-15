using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class ForecastDay
    {
        public string Weather { get; private set; }
        public string WeatherDescription { get; private set; }
        public double Temperature { get; private set; }
        public double TemperatureLow { get; private set; }
        public double TemperatureHigh { get; private set; }

        public ForecastDay(string weather, string weatherDesc, double temp, double tempLow, double tempHigh)
        {
            Weather = weather;
            WeatherDescription = weatherDesc;
            Temperature = temp;
            TemperatureLow = tempLow;
            TemperatureHigh = tempHigh;
        }
    }
}
