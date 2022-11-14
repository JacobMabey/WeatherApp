namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WeatherReceiver.Initialize("chicago");
            textBox1.Text = WeatherReceiver.GetCoords()[0] + " | " + WeatherReceiver.GetCoords()[1] + "\n" + WeatherReceiver.GetWeatherTitle() + "\n" + WeatherReceiver.GetWeatherDescription();
        }
    }
}