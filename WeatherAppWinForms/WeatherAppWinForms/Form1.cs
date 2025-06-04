using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppWinForms
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_getWeather_Click(object sender, EventArgs e)
        {
            string city = txtb_city.Text;
            string apiKey = "2d803c6ccbf1998cd0c9c6aa279636e8";
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            try
            {
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                lbl_temp.Text = $"Temperature: {weatherData.Main.Temp} °C";
                lbl_humidity.Text = $"Humidity: {weatherData.Main.Humidity} %";
                lbl_windSpeed.Text = $"Wind Speed: {weatherData.Wind.Speed} m/s";
                lbl_desc.Text = $"Description: {weatherData.Weather.FirstOrDefault()?.Description ?? "N/A"}";
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error fetching weather data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

// Mitchell Cornett, Sean Miles, Carmelo Vera