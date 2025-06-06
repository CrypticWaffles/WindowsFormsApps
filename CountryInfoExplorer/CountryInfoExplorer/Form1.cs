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

namespace CountryInfoExplorer
{
    public partial class Form1 : Form
    {
        private readonly HttpClient client;
        private const string BaseApiUrl = "https://restcountries.com/v3.1/";
        
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            ClearCountryInfo();

            string countryName = txt_countryName.Text;

            if (string.IsNullOrEmpty(countryName))
            {
                MessageBox.Show("Please enter a country name.");
                return;
            }

            string requestUrl = $"{BaseApiUrl}name/{countryName}";

            try
            {
                HttpResponseMessage res = await client.GetAsync(requestUrl);

                if (res.IsSuccessStatusCode)
                {
                    string jsonRes = await res.Content.ReadAsStringAsync();
                    List<Country> countriesCollection = JsonConvert.DeserializeObject<List<Country>>(jsonRes);

                    if (countriesCollection != null && countriesCollection.Any())
                    {
                        Country country = countriesCollection.FirstOrDefault();

                        if (country != null)
                        {
                            DisplayCountryInfo(country);
                        }
                        else
                        {
                            MessageBox.Show("Country data found but could not be processed.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Country not found. Please check your spelling or try another.");
                    }
                }
                else
                {
                    MessageBox.Show("Error fetching country data. Please try again later.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
        }

        // Loads country labels from selected country
        private void DisplayCountryInfo(Country country)
        {
            lbl_population.Text = $"{country.Population:N0}";
            lbl_region.Text = $"{country.Region}";
            lbl_subRegion.Text = $"{country.Subregion}";
            lbl_capital.Text = $"{(country.Capital != null && country.Capital.Any() ? string.Join(", ", country.Capital) : "N / A")}";
            // Attempts to load flag if available
            if (country.Flags != null && !string.IsNullOrEmpty(country.Flags.Png))
            {
                try
                {
                    using (var stream = client.GetStreamAsync(country.Flags.Png).Result)
                    {
                        pbx_flag.Image = Image.FromStream(stream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load flag: {ex.Message}");
                }
            }
            else
            {
                pbx_flag = null;
            }
        }

        // Clears country labels
        private void ClearCountryInfo()
        {
            lbl_population.Text = string.Empty;
            lbl_region.Text = string.Empty;
            lbl_subRegion.Text = string.Empty;
            lbl_capital.Text = string.Empty;
            pbx_flag.Image = null;
        }
    }
}
