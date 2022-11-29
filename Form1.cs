using System.Device.Location;
using Timer = System.Windows.Forms.Timer;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private Timer CLTimeoutTimer { get; set; }

        private bool loading = true;
        public bool Loading
        {
            get => loading;
            set
            {
                loading = value;
                if (lblLoading != null && pnlLoading != null)
                {
                    pnlLoading.Visible = loading;
                }
            }
        }

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public Form1()
        {
            InitializeLayout();
            InitializeComponent();
        }

        public void InitializeLayout()
        {
            Loading = true;
        }

        // This is validation so you cant type numbers into the city search
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = true;
            }
        }


        private void UpdateLayout(eUnits units)
        {
            //City name, weather description, and weather icon
            if (WeatherReceiver.City.Equals(""))
                lblCityName.Text = "NA";
            else lblCityName.Text = Capitalize(WeatherReceiver.City);
            lblWeatherDesc.Text = Capitalize(WeatherReceiver.WeatherDescription);

            
            //Load main weather icon
            pictureBox1.Load(WeatherReceiver.WeatherIconURL);

            //Change background color based on weather
            switch (WeatherReceiver.Weather)
            {
                case "Clear":
                    pnlLoading.BackColor = Color.LightSkyBlue;
                    this.BackColor = Color.LightSkyBlue;
                    break;
                case "Clouds":
                    pnlLoading.BackColor = Color.LightSteelBlue;
                    this.BackColor = Color.LightSteelBlue;
                    break;
                case "Rain":
                case "Drizzle":
                    pnlLoading.BackColor = Color.SteelBlue;
                    this.BackColor = Color.SteelBlue;
                    break;
                case "Thunderstorm":
                    pnlLoading.BackColor = Color.SteelBlue;
                    this.BackColor = Color.SteelBlue;
                    break;
                case "Snow":
                    pnlLoading.BackColor = Color.PowderBlue;
                    this.BackColor = Color.PowderBlue;
                    break;
                case "Mist":
                case "Smoke":
                case "Haze":
                case "Dust":
                case "Fog":
                case "Sand":
                case "Ash":
                case "Squall":
                case "Tornado":
                    pnlLoading.BackColor = Color.LightSteelBlue;
                    this.BackColor = Color.LightSteelBlue;
                    break;
                default:
                    pnlLoading.BackColor = Color.LightSkyBlue;
                    this.BackColor = Color.LightSkyBlue;
                    break;
            }


            //Temperature
            lblTemp.Text = WeatherReceiver.Temperature + "°";
            lblTempHighLow.Text = WeatherReceiver.TemperatureLow + "°/" + WeatherReceiver.TemperatureHigh + "°";
            lblTempFeelsLike.Text = "Feels Like: " + WeatherReceiver.TemperatureFeelsLike + "°";

            //Clouds, Sunrise/Sunset, Wind
            lblClouds.Text = "Clouds: " + WeatherReceiver.CloudRatio + "%";
            lblSunrise.Text = "Sunrise: " + WeatherReceiver.SunriseTime;
            lblSunset.Text = "Sunset: " + WeatherReceiver.SunsetTime;
            lblWind.Text = "Wind: " + WeatherReceiver.WindSpeed + (units == eUnits.IMPERIAL ? "mph " : "mps ") + WeatherReceiver.WindCardinalDirection;

            //Pressure, Humidity, Visibility
            lblPressure.Text = "Pressure: " + WeatherReceiver.Pressure + "hPa";
            lblHumidity.Text = "Humidity: " + WeatherReceiver.Humidity + "%";
            lblVisibility.Text = "Visibility: " + (WeatherReceiver.Visibility / 100) + "%";

            //Fill Forecast Days
            //Day 1
            lblForecastDay1.Text = WeatherReceiver.GetDayOfWeek(1);
            imgForecastIcon1.Load(WeatherReceiver.ForecastDays[0].WeatherIconUrl);
            lblForecastDesc1.Text = Capitalize(WeatherReceiver.ForecastDays[0].WeatherDescription);
            lblForecastTemp1.Text = WeatherReceiver.ForecastDays[0].Temperature + "° " + " (" + WeatherReceiver.ForecastDays[0].TemperatureLow + "°/" + WeatherReceiver.ForecastDays[0].TemperatureHigh + "°)";

            //Day 
            lblForecastDay2.Text = WeatherReceiver.GetDayOfWeek(2);
            imgForecastIcon2.Load(WeatherReceiver.ForecastDays[1].WeatherIconUrl);
            lblForecastDesc2.Text = Capitalize(WeatherReceiver.ForecastDays[1].WeatherDescription);
            lblForecastTemp2.Text = WeatherReceiver.ForecastDays[1].Temperature + "° " + " (" + WeatherReceiver.ForecastDays[1].TemperatureLow + "°/" + WeatherReceiver.ForecastDays[1].TemperatureHigh + "°)";

            //Day 3
            lblForecastDay3.Text = WeatherReceiver.GetDayOfWeek(3);
            imgForecastIcon3.Load(WeatherReceiver.ForecastDays[2].WeatherIconUrl);
            lblForecastDesc3.Text = Capitalize(WeatherReceiver.ForecastDays[2].WeatherDescription);
            lblForecastTemp3.Text = WeatherReceiver.ForecastDays[2].Temperature + "° " + " (" + WeatherReceiver.ForecastDays[2].TemperatureLow + "°/" + WeatherReceiver.ForecastDays[2].TemperatureHigh + "°)";

            //Day 4
            lblForecastDay4.Text = WeatherReceiver.GetDayOfWeek(4);
            imgForecastIcon4.Load(WeatherReceiver.ForecastDays[3].WeatherIconUrl);
            lblForecastDesc4.Text = Capitalize(WeatherReceiver.ForecastDays[3].WeatherDescription);
            lblForecastTemp4.Text = WeatherReceiver.ForecastDays[3].Temperature + "° " + " (" + WeatherReceiver.ForecastDays[3].TemperatureLow + "°/" + WeatherReceiver.ForecastDays[3].TemperatureHigh + "°)";

            //Day 5
            lblForecastDay5.Text = WeatherReceiver.GetDayOfWeek(5);
            imgForecastIcon5.Load(WeatherReceiver.ForecastDays[4].WeatherIconUrl);
            lblForecastDesc5.Text = Capitalize(WeatherReceiver.ForecastDays[4].WeatherDescription);
            lblForecastTemp5.Text = WeatherReceiver.ForecastDays[4].Temperature + "° " + " (" + WeatherReceiver.ForecastDays[4].TemperatureLow + "°/" + WeatherReceiver.ForecastDays[4].TemperatureHigh + "°)";

            //Day 6
            lblForecastDay6.Text = WeatherReceiver.GetDayOfWeek(6);
            imgForecastIcon6.Load(WeatherReceiver.ForecastDays[5].WeatherIconUrl);
            lblForecastDesc6.Text = Capitalize(WeatherReceiver.ForecastDays[5].WeatherDescription);
            lblForecastTemp6.Text = WeatherReceiver.ForecastDays[5].Temperature + "° " + " (" + WeatherReceiver.ForecastDays[5].TemperatureLow + "°/" + WeatherReceiver.ForecastDays[5].TemperatureHigh + "°)";
        }

        private string Capitalize(string text)
        {
            text = text.Trim();
            if (text.Equals("")) return text;
            string[] splitText = text.Split();
            if (splitText.Length == 1)
                return text.Substring(0, 1).ToUpper() + text.Substring(1).ToLower();
            for (int i = 0; i < splitText.Length; i++)
            {
                if (splitText[i].Equals("")) continue;
                splitText[i] = splitText[i].Substring(0, 1).ToUpper() + splitText[i].Substring(1).ToLower();
            }
            text = string.Join(' ', splitText);
            return text;
        }

        private void btnCurrentLocation_Click(object sender, EventArgs e)
        {
            eUnits units = eUnits.IMPERIAL;
            WeatherReceiver.Initialize(units);

            UpdateLayout(units);
        }

        private void btnCitySearch_Click(object sender, EventArgs e)
        {
            string city = CitySearchTextBox.Text;
            eUnits units = eUnits.IMPERIAL;
            if (!WeatherReceiver.Initialize(city, units))
                return;
            CitySearchTextBox.Text = "";

            UpdateLayout(units);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CLTimeoutTimer = new Timer();
            CLTimeoutTimer.Interval = 5000;
            CLTimeoutTimer.Tick += new EventHandler(TimerEventProcessor);

            WeatherReceiver.InitializeGeoLocation();
            WeatherReceiver.CurrentLocation.watcher.StatusChanged += Watcher_StatusChanged;

            CLTimeoutTimer.Start();
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            string defaultCity = "chicago";
            eUnits units = eUnits.IMPERIAL;
            bool success = WeatherReceiver.Initialize(defaultCity, units);
            if (success)
            {
                UpdateLayout(units);
                Loading = false;

                //After timeout, disable current location button
                btnCurrentLocation.Visible = false;
            }
            else
            {
                lblLoading.Text = "No Connection";
            }
        }

        private void Watcher_StatusChanged(object? sender, GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready && CLTimeoutTimer.Enabled)
            {
                CLTimeoutTimer.Stop();
                eUnits units = eUnits.IMPERIAL;
                bool success = WeatherReceiver.Initialize(units);
                if (success)
                {
                    UpdateLayout(units);
                    Loading = false;
                } else
                {
                    lblLoading.Text = "No Connection";
                }
            }
        }
    }
}