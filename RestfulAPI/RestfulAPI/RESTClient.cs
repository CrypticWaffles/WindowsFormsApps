using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestfulAPI
{
    public enum HttpMethod // Limits the options to those listed
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class RESTClient
    {
        // Fields
        public string URL { get; set; } // The URL to which the request will be sent
        public HttpMethod Method { get; set; } // The HTTP method to be used for the request (GET, POST, etc.)
        public string postJsonData { get; set; } // For POST requests, this will hold the JSON data to be sent

        // Constructor
        public RESTClient() 
        {
            URL = string.Empty;
            Method = HttpMethod.GET; // Default method is GET
        }

        public string makeRequest()
        {
            string responseContent = string.Empty;

            HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create(URL);

            request.Method = Method.ToString();

            // Add data to the request
            // Post Start
            if (request.Method == "POST" && postJsonData != string.Empty)
            {
                request.ContentType = "application/json";
                using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.Write(postJsonData);
                    writer.Close();
                }
            }
            // Post End
            // PUT Start
            // PUT End
            // DELETE Start
            // DELETE End
            // Get JSON data from internet API & add it to the string
            HttpWebResponse response = null;

            try
            {
                // Get response from server(API)
                response = (HttpWebResponse)request.GetResponse();
                using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                {
                    responseContent = reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)ex.Response)
                    {
                        using (var reader = new System.IO.StreamReader(errorResponse.GetResponseStream()))
                        {
                            responseContent = reader.ReadToEnd();
                        }
                    }
                }
                else
                {
                    responseContent = ex.Message;
                }
            }
            finally
            {
                response?.Close();
            }
            // Return string
            return responseContent;
        }
    }
}
