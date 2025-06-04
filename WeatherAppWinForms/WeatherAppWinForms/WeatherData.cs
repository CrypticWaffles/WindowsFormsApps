using System.Windows.Forms;

namespace WeatherAppWinForms
{
    public class WeatherData
    {
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public Weather[] Weather { get; set; }
    }

    public class Main
    {
        public float Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class Wind
    {
        public float Speed { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
    }
}