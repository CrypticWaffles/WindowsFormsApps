using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestfulAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            // Declare the object
            RESTClient client = new RESTClient();
            
            // Set the URL
            client.URL = txtb_url.Text;

            switch(cmb_method.SelectedItem.ToString())
            {
                case "POST":
                    client.Method = HttpMethod.POST;
                    client.postJsonData = rtxtb_data.Text;
                    break;
                case "PUT":
                    client.Method = HttpMethod.PUT;
                    break;
                case "DELETE":
                    client.Method = HttpMethod.DELETE;
                    break;
                default:
                    client.Method = HttpMethod.GET;
                    break;
            }

            // Call the makeRequest method to get the JSON data
            string jsonData = client.makeRequest();

            // Display the JSON data in the rich text box
            rtxtb_response.Text = jsonData;
        }
    }
}
