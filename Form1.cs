namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WeatherReceiver.Initialize("Draper", eUnits.IMPERIAL);
            string text = "";
            text += WeatherReceiver.City + Environment.NewLine;
            text += WeatherReceiver.Coords[0] + "  |  " + WeatherReceiver.Coords[1] + Environment.NewLine;
            text += WeatherReceiver.Weather + Environment.NewLine;
            text += WeatherReceiver.WeatherDescription + Environment.NewLine;
            text += "Clouds: " + WeatherReceiver.CloudRatio + "%" + Environment.NewLine;
            text += WeatherReceiver.Temperature + "  |  Feels Like: " + WeatherReceiver.TemperatureFeelsLike + Environment.NewLine;
            text += "v" + WeatherReceiver.TemperatureLow + "  |  ^" + WeatherReceiver.TemperatureHigh + Environment.NewLine;
            text += WeatherReceiver.Humidity + Environment.NewLine;
            text += "~ " + WeatherReceiver.WindSpeed + "mph  |  ~ " + WeatherReceiver.WindDirection + " deg" + Environment.NewLine;
            text += "@^" + WeatherReceiver.SunriseTime + "  |  @v" + WeatherReceiver.SunsetTime + Environment.NewLine;

            foreach (ForecastDay day in WeatherReceiver.ForecastDays)
            {
                text += day.Weather + " | " + day.WeatherDescription + "       " + day.Temperature + " | v" + day.TemperatureLow + " | ^" + day.TemperatureHigh + Environment.NewLine;
            }

            textBox1.Text = text;
        }
    }
}