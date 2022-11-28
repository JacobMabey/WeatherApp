using System.Device.Location;

namespace WeatherApp
{
    public partial class Form1 : Form
    {

        private bool loading = true;
        public bool Loading
        {
            get => loading;
            set
            {
                loading = value;
                if (lblLoading != null && pnlLoading != null)
                {
                    lblLoading.Visible = loading;
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

        private void btnCitySearch_Click(object sender, EventArgs e)
        {
            String city = CitySearchTextBox.Text;
            eUnits units = eUnits.IMPERIAL;
            if (!WeatherReceiver.Initialize(city, units))
                return;

            UpdateLayout(units);
        }


        private void UpdateLayout(eUnits units)
        {
            Loading = true;

            //City name, weather description, and weather icon
            if (WeatherReceiver.City.Equals(""))
                lblCityName.Text = "NA";
            else lblCityName.Text = WeatherReceiver.City.Substring(0, 1).ToUpper() + WeatherReceiver.City.Substring(1).ToLower();
            lblWeatherDesc.Text = WeatherReceiver.WeatherDescription;

            // Main GIF stuff
            //if (WeatherReceiver.WeatherDescription == "overcast clouds") {
            //    pictureBox1.Image = Properties.Resources.Thunderstorm;
            //} else {
            //    pictureBox1.Image = Properties.Resources.GIFTest;
            //}

            switch (WeatherReceiver.WeatherDescription) {
                case "broken clouds":
                case "overcast clouds":
                case "scattered clouds":
                    pictureBox1.Image = Properties.Resources.Clouds;
                    pnlLoading.BackColor = Color.LightSteelBlue;
                    this.BackColor = Color.LightSteelBlue;
                    break;
                case "rain":
                case "heavy intensity rain":
                    pictureBox1.Image = Properties.Resources.Rain;
                    pnlLoading.BackColor = Color.SteelBlue;
                    this.BackColor = Color.SteelBlue;
                    break;
                case "haze":
                case "mist":
                    pictureBox1.Image = Properties.Resources.Haze;
                    pnlLoading.BackColor = Color.LightSteelBlue;
                    this.BackColor = Color.LightSteelBlue;
                    break;
                case "clear sky":
                    pictureBox1.Image = Properties.Resources.ClearSkies;
                    pnlLoading.BackColor = Color.LightSkyBlue;
                    this.BackColor = Color.LightSkyBlue;
                    break;
                case "light snow":
                    pictureBox1.Image = Properties.Resources.Snow;
                    pnlLoading.BackColor = Color.PowderBlue;
                    this.BackColor = Color.PowderBlue;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.GIFTest;
                    pnlLoading.BackColor = Color.LightSkyBlue;
                    this.BackColor = Color.LightSkyBlue;
                    break;
            }

            // Weather Images for other days

            //icon

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
            lblForecastDesc1.Text = WeatherReceiver.ForecastDays[0].WeatherDescription;
            lblForecastTemp1.Text = "Temp: " + WeatherReceiver.ForecastDays[0].Temperature + "° " + " (" + WeatherReceiver.ForecastDays[0].TemperatureLow + "°/" + WeatherReceiver.ForecastDays[0].TemperatureHigh + "°)";

            //Day 
            lblForecastDay2.Text = WeatherReceiver.GetDayOfWeek(2);
            imgForecastIcon2.Load(WeatherReceiver.ForecastDays[1].WeatherIconUrl);
            lblForecastDesc2.Text = WeatherReceiver.ForecastDays[1].WeatherDescription;
            lblForecastTemp2.Text = "Temp: " + WeatherReceiver.ForecastDays[1].Temperature + "° " + " (" + WeatherReceiver.ForecastDays[1].TemperatureLow + "°/" + WeatherReceiver.ForecastDays[1].TemperatureHigh + "°)";

            //Day 3
            lblForecastDay3.Text = WeatherReceiver.GetDayOfWeek(3);
            imgForecastIcon3.Load(WeatherReceiver.ForecastDays[2].WeatherIconUrl);
            lblForecastDesc3.Text = WeatherReceiver.ForecastDays[2].WeatherDescription;
            lblForecastTemp3.Text = "Temp: " + WeatherReceiver.ForecastDays[2].Temperature + "° " + " (" + WeatherReceiver.ForecastDays[2].TemperatureLow + "°/" + WeatherReceiver.ForecastDays[2].TemperatureHigh + "°)";

            //Day 4
            lblForecastDay4.Text = WeatherReceiver.GetDayOfWeek(4);
            imgForecastIcon4.Load(WeatherReceiver.ForecastDays[3].WeatherIconUrl);
            lblForecastDesc4.Text = WeatherReceiver.ForecastDays[3].WeatherDescription;
            lblForecastTemp4.Text = "Temp: " + WeatherReceiver.ForecastDays[3].Temperature + "° " + " (" + WeatherReceiver.ForecastDays[3].TemperatureLow + "°/" + WeatherReceiver.ForecastDays[3].TemperatureHigh + "°)";

            //Day 5
            lblForecastDay5.Text = WeatherReceiver.GetDayOfWeek(5);
            imgForecastIcon5.Load(WeatherReceiver.ForecastDays[4].WeatherIconUrl);
            lblForecastDesc5.Text = WeatherReceiver.ForecastDays[4].WeatherDescription;
            lblForecastTemp5.Text = "Temp: " + WeatherReceiver.ForecastDays[4].Temperature + "° " + " (" + WeatherReceiver.ForecastDays[4].TemperatureLow + "°/" + WeatherReceiver.ForecastDays[4].TemperatureHigh + "°)";

            //Day 6
            lblForecastDay6.Text = WeatherReceiver.GetDayOfWeek(6);
            imgForecastIcon6.Load(WeatherReceiver.ForecastDays[5].WeatherIconUrl);
            lblForecastDesc6.Text = WeatherReceiver.ForecastDays[5].WeatherDescription;
            lblForecastTemp6.Text = "Temp: " + WeatherReceiver.ForecastDays[5].Temperature + "° " + " (" + WeatherReceiver.ForecastDays[5].TemperatureLow + "°/" + WeatherReceiver.ForecastDays[5].TemperatureHigh + "°)";

            Loading = false;
        }

        private void btnCurrentLocation_Click(object sender, EventArgs e)
        {
            eUnits units = eUnits.IMPERIAL;
            WeatherReceiver.Initialize(units);

            UpdateLayout(units);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WeatherReceiver.InitializeGeoLocation();
            WeatherReceiver.CurrentLocation.watcher.StatusChanged += Watcher_StatusChanged;
        }

        private void Watcher_StatusChanged(object? sender, GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready)
            {
                eUnits units = eUnits.IMPERIAL;
                WeatherReceiver.Initialize(units);
                UpdateLayout(units);
            }
        }
    }
}