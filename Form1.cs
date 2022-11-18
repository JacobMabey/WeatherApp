namespace WeatherApp
{
    public partial class Form1 : Form
    {
       

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public Form1()
        {
            InitializeComponent();
            InitializeLayout();
        }

        public void InitializeLayout()
        {
            eUnits units = eUnits.IMPERIAL;
            WeatherReceiver.Initialize("Draper", units);
            DisplayedCityName.Text = WeatherReceiver.City;
            label8.Text = WeatherReceiver.Temperature.ToString() + "°";
            label2.Text = WeatherReceiver.WeatherDescription;
            label3.Text = "Clouds: " + WeatherReceiver.CloudRatio.ToString() + "%";
            label9.Text = WeatherReceiver.TemperatureLow.ToString() + "°" + "/" + WeatherReceiver.TemperatureHigh.ToString() + "°";
            label10.Text = "Feels Like: " + WeatherReceiver.TemperatureFeelsLike.ToString() + "°";
            label11.Text = "Sunrise: " + WeatherReceiver.SunriseTime;
            label12.Text = "Sunset: " + WeatherReceiver.SunsetTime;
            label4.Text = "Wind: " + WeatherReceiver.WindSpeed.ToString() + (units == eUnits.IMPERIAL ? "mph" : "kph") +
                "  Wind Direction:" + WeatherReceiver.WindDirection.ToString() + "°";
            //pressure here
            //visibiltiy
            label6.Text = "Humidity: " + WeatherReceiver.Humidity.ToString() + "%";
            label19.Text = WeatherReceiver.ForecastDays.ElementAt(0).WeatherDescription;
            label25.Text = "Temp: " + WeatherReceiver.ForecastDays.ElementAt(0).Temperature.ToString() + "° " + " ( "+ WeatherReceiver.ForecastDays.ElementAt(0).TemperatureLow + "° / " + WeatherReceiver.ForecastDays.ElementAt(0).TemperatureHigh + "° ) ";

            label20.Text = WeatherReceiver.ForecastDays.ElementAt(1).WeatherDescription;
            label26.Text = "Temp: " + WeatherReceiver.ForecastDays.ElementAt(1).Temperature.ToString() + "° " + " ( "+ WeatherReceiver.ForecastDays.ElementAt(1).TemperatureLow + "° / " + WeatherReceiver.ForecastDays.ElementAt(1).TemperatureHigh + "° ) ";
            
            label21.Text = WeatherReceiver.ForecastDays.ElementAt(2).WeatherDescription;
            label27.Text = "Temp: " + WeatherReceiver.ForecastDays.ElementAt(2).Temperature.ToString() + "° " + " ( "+ WeatherReceiver.ForecastDays.ElementAt(2).TemperatureLow + "° / " + WeatherReceiver.ForecastDays.ElementAt(2).TemperatureHigh + "° ) ";
           
            label22.Text = WeatherReceiver.ForecastDays.ElementAt(3).WeatherDescription;
            label28.Text = "Temp: " + WeatherReceiver.ForecastDays.ElementAt(3).Temperature.ToString() + "° " + " ( "+ WeatherReceiver.ForecastDays.ElementAt(3).TemperatureLow + "° / " + WeatherReceiver.ForecastDays.ElementAt(3).TemperatureHigh + "° ) ";
           
            label23.Text = WeatherReceiver.ForecastDays.ElementAt(4).WeatherDescription;
            label29.Text = "Temp: " + WeatherReceiver.ForecastDays.ElementAt(4).Temperature.ToString() + "° " + " ( "+ WeatherReceiver.ForecastDays.ElementAt(4).TemperatureLow + "° / " + WeatherReceiver.ForecastDays.ElementAt(4).TemperatureHigh + "° ) ";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        // This is validation so you cant type numbers into the city search
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
                e.Handled = true;
            }
        }

        // If you press enter do stuff
        private void CitySearchTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                DisplayedCityName.Text = CitySearchTextBox.Text;
                CitySearchTextBox.Text = "";
            }
        }

        private void CitySearchTextBox_TextChanged(object sender, EventArgs e) {
            
        }
        // Most of these click events were made on accident and likely wont be used
    }
}