using System;
using System.Net;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WeatherApp
{
    public static class WeatherReceiver
    {
        public static bool Initialized { get; private set; }

        #nullable disable
        private static JsonNode weatherJson, forecastJson;

        public static string City { get; private set; } = "";
        public static eUnits Units { get; private set; } = eUnits.METRIC;
        private static string UnitsString { get => Units == eUnits.METRIC ? "metric" : "imperial"; }

        public static List<ForecastDay> ForecastDays { get; private set; } = new List<ForecastDay>();

        /**
         * Latitude & Longitude coordinates of the current city
         */
        public static double[] Coords
        {
            get {
                if (weatherJson == null) return new double[] { 0, 0 };
                double lat = double.Parse(weatherJson["coord"]["lat"].ToString());
                double lon = double.Parse(weatherJson["coord"]["lon"].ToString());
                return new double[] { lat, lon };
            }
        }

        /**
         * Main Weather Title (Sunny, Cloudy, etc.)
         */
        public static string Weather
        {
            get
            {
                if (weatherJson == null) return "NA";
                string title = weatherJson["weather"][0]["main"].ToString();
                return title;
            }
        }

        /**
         * Gets weather description
         */
        public static string WeatherDescription
        {
            get
            {
                if (weatherJson == null) return "NA";
                string title = weatherJson["weather"][0]["description"].ToString();
                return title;
            }
        }

        /**
         * Gets current humidity
         */
        public static int Humidity
        {
            get
            {
                if (weatherJson == null) return 50;
                int humidity = int.Parse(weatherJson["main"]["humidity"].ToString());
                return humidity;
            }
        }

        /**
         * Gets current wind speed in mph
         */
        public static double WindSpeed
        {
            get
            {
                if (weatherJson == null) return 0.0;
                double speed = double.Parse(weatherJson["wind"]["speed"].ToString());
                return speed;
            }
        }

        /**
         * Gets wind direction in degrees
         */
        public static int WindDirection
        {
            get
            {
                if (weatherJson == null) return 0;
                int dir = int.Parse(weatherJson["wind"]["deg"].ToString());
                return dir;
            }
        }

        /**
         * Gets percentage of clouds 0-100
         */
        public static int CloudRatio
        {
            get
            {
                if (weatherJson == null) return 0;
                int ratio = int.Parse(weatherJson["clouds"]["all"].ToString());
                return ratio;
            }
        }

        /**
         * Gets time of sunrise
         */
        public static string SunriseTime
        {
            get
            {
                if (weatherJson == null) return "00:00";
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                long timestamp = long.Parse(weatherJson["sys"]["sunrise"].ToString());
                dateTime = dateTime.AddSeconds(timestamp).ToLocalTime();
                return dateTime.ToString("h:mm tt");
            }
        }

        /**
         * Gets time of sunset
         */
        public static string SunsetTime
        {
            get
            {
                if (weatherJson == null) return "00:00";
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                long timestamp = long.Parse(weatherJson["sys"]["sunset"].ToString());
                dateTime = dateTime.AddSeconds(timestamp).ToLocalTime();
                return dateTime.ToString("h:mm tt");
            }
        }

        /**
         * Gets current Temperature
         */
        public static double Temperature
        {
            get
            {
                if (weatherJson == null) return 0;
                double temp = double.Parse(weatherJson["main"]["temp"].ToString());
                return temp;
            }
        }
        /**
         * Gets current Lowest Temperature
         */
        public static double TemperatureLow
        {
            get
            {
                if (weatherJson == null) return 0;
                double temp = double.Parse(weatherJson["main"]["temp_min"].ToString());
                return temp;
            }
        }
        /**
         * Gets current Highest Temperature
         */
        public static double TemperatureHigh
        {
            get
            {
                if (weatherJson == null) return 0;
                double temp = double.Parse(weatherJson["main"]["temp_max"].ToString());
                return temp;
            }
        }
        /**
         * Gets current feels-like Temperature
         */
        public static double TemperatureFeelsLike
        {
            get
            {
                if (weatherJson == null) return 0;
                double temp = double.Parse(weatherJson["main"]["feels_like"].ToString());
                return temp;
            }
        }


        /**
         * Initializes API with a selected city and units of measurement
         */
        public static bool Initialize(string city, eUnits units)
        {
            try
            {
                City = city.ToLower().Trim(' ', ',', '.', '/', '(', ')', '\'', '\"');
                Units = units;
                weatherJson = GetCityWeatherJSON(city);
                double lat = double.Parse(weatherJson["coord"]["lat"].ToString());
                double lon = double.Parse(weatherJson["coord"]["lon"].ToString());
                forecastJson = GetCityForecastJSON(lat, lon);
                InitializeForecastList();
                Initialized = true;
            } catch
            {
                City = "";
                Units = eUnits.METRIC;
                weatherJson = null;
                forecastJson = null;
                Initialized= false;
                return Initialized;
            }
            return Initialized;
        }

        /**
         * Initializes API with latitude & longitude coordinates and units of measurement
         */
        public static bool Initialize(double lat, double lon, eUnits units)
        {
            try
            {
                Units = units;
                weatherJson = GetCityWeatherJSON(lat, lon);
                City = weatherJson["name"].ToString();
                forecastJson = GetCityForecastJSON(lat, lon);
                InitializeForecastList();
                Initialized = true;
            }
            catch
            {
                City = "";
                Units = eUnits.METRIC;
                weatherJson = null;
                forecastJson = null;
                Initialized = false;
                return Initialized;
            }
            return Initialized;
        }


        /**
         * Initailizes and fills the list of the next 5 days forecast
         */
        private static bool InitializeForecastList()
        {
            if (forecastJson == null) return false;

            for (int i = 0; i < 5; i++)
            {
                double temp = double.Parse(forecastJson["list"][i]["main"]["temp"].ToString());
                double tempLow = double.Parse(forecastJson["list"][i]["main"]["temp_min"].ToString());
                double tempHigh = double.Parse(forecastJson["list"][i]["main"]["temp_max"].ToString());
                string weather = forecastJson["list"][i]["weather"][0]["main"].ToString();
                string weatherDesc = forecastJson["list"][i]["weather"][0]["description"].ToString();
                ForecastDay day = new ForecastDay(weather, weatherDesc, temp, tempLow, tempHigh);
                ForecastDays.Add(day);
            }
            return true;
        }




        /**
         * Receives weather JSON data for current day info
         */
        #pragma warning disable SYSLIB0014
        private static JsonNode GetCityWeatherJSON(string city, string state, string country)
        {
            //Get current weather data
            var weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?appid=910b890df0a91b53bc4afe41a18a08e3&q={city}" + (state.Equals("") ? "" : ","+state) + (country.Equals("") ? "" : "," + country) + $"&units={UnitsString}";
            var result = "";
            
            var httpWeatherRequest = (HttpWebRequest)WebRequest.Create(weatherUrl);
            httpWeatherRequest.Accept = "application/json";
            var httpWeatherResponse = (HttpWebResponse)httpWeatherRequest.GetResponse();
            using (var streamReader = new StreamReader(httpWeatherResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return ParseJSON(result);
        }
        private static JsonNode GetCityWeatherJSON(string city, string country) => GetCityWeatherJSON(city, "", country);
        private static JsonNode GetCityWeatherJSON(string city) => GetCityWeatherJSON(city, "", "");

        #pragma warning disable SYSLIB0014
        private static JsonNode GetCityWeatherJSON(double lat, double lon)
        {
            //Get current weather data
            var weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid=910b890df0a91b53bc4afe41a18a08e3&units={UnitsString}";
            var result = "";

            var httpWeatherRequest = (HttpWebRequest)WebRequest.Create(weatherUrl);
            httpWeatherRequest.Accept = "application/json";
            var httpWeatherResponse = (HttpWebResponse)httpWeatherRequest.GetResponse();
            using (var streamReader = new StreamReader(httpWeatherResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            return ParseJSON(result);
        }

        /**
         * Receives weather JSON data for next 5 days info
         */
        #pragma warning disable SYSLIB0014
        private static JsonNode GetCityForecastJSON(double lat, double lon)
        {
            //Get next 5 days weather data
            var forecastUrl = $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&appid=910b890df0a91b53bc4afe41a18a08e3&units={UnitsString}";
            var result = "";

            var httpForecastRequest = (HttpWebRequest)WebRequest.Create(forecastUrl);
            httpForecastRequest.Accept = "application/json";
            var httpForecastResponse = (HttpWebResponse)httpForecastRequest.GetResponse();
            using (var streamReader = new StreamReader(httpForecastResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return ParseJSON(result);
        }


        private static JsonNode ParseJSON(string json)
        {
            if (json.Equals("")) return null;
            JsonNode node = JsonNode.Parse(json);
            return node;
        }
    }

    public enum eUnits
    {
        IMPERIAL, METRIC
    }





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
