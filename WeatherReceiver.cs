using System;
using System.Net;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.Logging;
using System.Device.Location;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WeatherApp
{
    public static class WeatherReceiver
    {
        public static bool Initialized { get; private set; }

        #nullable disable
        private static JsonNode weatherJson, forecastJson;

        public static CLocation CurrentLocation { get; private set; }

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
         * Gets current air pressure
         */
        public static int Pressure
        {
            get
            {
                if (weatherJson == null) return 50;
                int humidity = int.Parse(weatherJson["main"]["pressure"].ToString());
                return humidity;
            }
        }

        /**
         * Gets current humidity
         */
        public static int Visibility
        {
            get
            {
                if (weatherJson == null) return 50;
                int humidity = int.Parse(weatherJson["visibility"].ToString());
                return humidity;
            }
        }

        /**
         * Gets current wind speed in mph
         */
        public static int WindSpeed
        {
            get
            {
                if (weatherJson == null) return 0;
                int speed = (int)Math.Round(double.Parse(weatherJson["wind"]["speed"].ToString()));
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
         * Gets wind cardinal Direction
         */
        public static String WindCardinalDirection
        {
            get
            {
                String wind = "N";
                int windDir = WindDirection;
                if ((windDir >= 338 && windDir <= 360) || (windDir >= 0 && windDir <= 22))
                    wind = "N";
                else if (windDir >= 23 && windDir <= 67)
                    wind = "NE";
                else if (windDir >= 68 && windDir <= 112)
                    wind = "E";
                else if (windDir >= 113 && windDir <= 157)
                    wind = "SE";
                else if (windDir >= 158 && windDir <= 202)
                    wind = "S";
                else if (windDir >= 203 && windDir <= 247)
                    wind = "SW";
                else if (windDir >= 248 && windDir <= 292)
                    wind = "W";
                else if (windDir >= 293 && windDir <= 337)
                    wind = "NW";
                else
                    wind = "NA";

                return wind;
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
        public static int Temperature
        {
            get
            {
                if (weatherJson == null) return 0;
                int temp = (int)Math.Round(double.Parse(weatherJson["main"]["temp"].ToString()));
                return temp;
            }
        }
        /**
         * Gets current Lowest Temperature
         */
        public static int TemperatureLow
        {
            get
            {
                if (weatherJson == null) return 0;
                int temp = (int)Math.Round(double.Parse(weatherJson["main"]["temp_min"].ToString()));
                return temp;
            }
        }
        /**
         * Gets current Highest Temperature
         */
        public static int TemperatureHigh
        {
            get
            {
                if (weatherJson == null) return 0;
                int temp = (int)Math.Round(double.Parse(weatherJson["main"]["temp_max"].ToString()));
                return temp;
            }
        }
        /**
         * Gets current feels-like Temperature
         */
        public static int TemperatureFeelsLike
        {
            get
            {
                if (weatherJson == null) return 0;
                int temp = (int)Math.Round(double.Parse(weatherJson["main"]["feels_like"].ToString()));
                return temp;
            }
        }

        public static String WeatherIconURL
        {
            get
            {
                if (weatherJson == null) return "";
                return $"http://openweathermap.org/img/wn/{weatherJson["weather"][0]["icon"].ToString()}@4x.png";
            }
        }

        /**
         * Get current day of week
         */
        public static String GetDayOfWeek(int addDays = 0)
        {
            return DateTime.Now.AddDays(addDays).ToString("ddd");
        }



        /**
         * Initializes API with current location and units of measurement
         */
        public static bool Initialize(eUnits units)
        {
            
            double lat = CurrentLocation.Latitude;
            double lon = CurrentLocation.Longitude;

            Initialized = Initialize(lat, lon, units);
            return Initialized;
        }

        /**
         * Initializes API with a selected city and units of measurement
         */
        public static bool Initialize(string city, eUnits units)
        {
            City = "";
            Units = units;
            weatherJson = null;
            forecastJson = null;
            Initialized = false;
            try
            {
                weatherJson = GetCityWeatherJSON(city);
                if (weatherJson == null)
                    throw new ArgumentException();
                double lat = double.Parse(weatherJson["coord"]["lat"].ToString());
                double lon = double.Parse(weatherJson["coord"]["lon"].ToString());
                forecastJson = GetCityForecastJSON(lat, lon);
                if (forecastJson == null)
                    throw new ArgumentException();
                InitializeForecastList();
                City = city.ToLower().Trim(' ', ',', '.', '/', '(', ')', '\'', '\"');
                Units = units;
                Initialized = true;
            } catch (ArgumentException)
            {
                weatherJson = null;
                forecastJson = null;
                City = "";
                Units = eUnits.METRIC;
                Initialized = false;
            }
            return Initialized;
        }

        /**
         * Initializes API with latitude & longitude coordinates and units of measurement
         */
        public static bool Initialize(double lat, double lon, eUnits units)
        {
            City = "";
            Units = units;
            weatherJson = null;
            forecastJson = null;
            Initialized = false;
            try
            {
                weatherJson = GetCityWeatherJSON(lat, lon);
                if (weatherJson == null)
                    throw new ArgumentException();
                City = weatherJson["name"].ToString();
                forecastJson = GetCityForecastJSON(lat, lon);
                if (forecastJson == null)
                    throw new ArgumentException();
                InitializeForecastList();
                Units = units;
                Initialized = true;
            }
            catch (ArgumentException)
            {
                weatherJson = null;
                forecastJson = null;
                City = "";
                Units = eUnits.METRIC;
                Initialized = false;
            }
            return Initialized;
        }


        /**
         * Initailizes and fills the list of the next 5 days forecast
         */
        private static bool InitializeForecastList()
        {
            if (forecastJson == null) return false;

            ForecastDays.Clear();
            for (int i = 0; i < 6; i++)
            {
                int temp = (int)Math.Round(double.Parse(forecastJson["list"][i]["main"]["temp"].ToString()));
                int tempLow = (int)Math.Round(double.Parse(forecastJson["list"][i]["main"]["temp_min"].ToString()));
                int tempHigh = (int)Math.Round(double.Parse(forecastJson["list"][i]["main"]["temp_max"].ToString()));
                string weather = forecastJson["list"][i]["weather"][0]["main"].ToString();
                string weatherDesc = forecastJson["list"][i]["weather"][0]["description"].ToString();
                string weatherIcon = forecastJson["list"][i]["weather"][0]["icon"].ToString();
                ForecastDay day = new ForecastDay(weather, weatherDesc, temp, tempLow, tempHigh, weatherIcon);
                ForecastDays.Add(day);
            }
            return true;
        }


        /**
         * Initializes geo coordinate system to get current device location
         */
        public static bool InitializeGeoLocation()
        {
            CurrentLocation = new CLocation();
            CurrentLocation.GetLocationDataEvent();

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

            try
            {
                var httpWeatherRequest = (HttpWebRequest)WebRequest.Create(weatherUrl);
                httpWeatherRequest.Accept = "application/json";
                var httpWeatherResponse = (HttpWebResponse)httpWeatherRequest.GetResponse();
                using (var streamReader = new StreamReader(httpWeatherResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                JsonNode resultNode = ParseJSON(result);
                if (resultNode["cod"].ToString().Equals("404"))
                    throw new ArgumentException(resultNode["message"].ToString());
                return resultNode;
            } catch (WebException)
            {
                return null;
            }
        }
        private static JsonNode GetCityWeatherJSON(string city, string country) => GetCityWeatherJSON(city, "", country);
        private static JsonNode GetCityWeatherJSON(string city) => GetCityWeatherJSON(city, "", "");

        #pragma warning disable SYSLIB0014
        private static JsonNode GetCityWeatherJSON(double lat, double lon)
        {
            //Get current weather data
            var weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid=910b890df0a91b53bc4afe41a18a08e3&units={UnitsString}";
            var result = "";

            try
            {
                var httpWeatherRequest = (HttpWebRequest)WebRequest.Create(weatherUrl);
                httpWeatherRequest.Accept = "application/json";
                var httpWeatherResponse = (HttpWebResponse)httpWeatherRequest.GetResponse();
                using (var streamReader = new StreamReader(httpWeatherResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                return ParseJSON(result);
            }
            catch (WebException)
            {
                return null;
            }
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

            try
            {
                var httpForecastRequest = (HttpWebRequest)WebRequest.Create(forecastUrl);
                httpForecastRequest.Accept = "application/json";
                var httpForecastResponse = (HttpWebResponse)httpForecastRequest.GetResponse();
                using (var streamReader = new StreamReader(httpForecastResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return ParseJSON(result);
            }
            catch (WebException)
            {
                return null;
            }
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
        public int Temperature { get; private set; }
        public int TemperatureLow { get; private set; }
        public int TemperatureHigh { get; private set; }
        public string WeatherIconUrl { get; private set; }

        public ForecastDay(string weather, string weatherDesc, int temp, int tempLow, int tempHigh, string weatherIcon)
        {
            Weather = weather;
            WeatherDescription = weatherDesc;
            Temperature = temp;
            TemperatureLow = tempLow;
            TemperatureHigh = tempHigh;
            WeatherIconUrl = $"http://openweathermap.org/img/wn/{weatherIcon}@2x.png";
        }
    }

    public class CLocation
    {
        public GeoCoordinateWatcher watcher;
        public double Latitude { get; private set; }   
        public double Longitude { get; private set; }

        public void GetLocationDataEvent()
        {
            this.watcher = new GeoCoordinateWatcher();
            watcher.StatusChanged += Watcher_StatusChanged;
            this.watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));
        }

        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready)
            {
                // Display the latitude and longitude.
                if (watcher.Position.Location.IsUnknown)
                {
                    Latitude = 0;
                    Longitude = 0;
                }
                else
                {
                    GeoCoordinate location = watcher.Position.Location;
                    Latitude = location.Latitude;
                    Longitude = location.Longitude;
                }
            }
        }
    }
}
