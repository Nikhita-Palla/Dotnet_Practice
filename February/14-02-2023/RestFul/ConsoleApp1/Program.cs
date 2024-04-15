using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Base URL of the RESTful API
            // Base URL of the RESTful API
            string baseUrl = "http://localhost:63277/api/product";

            // Create an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send a GET request to retrieve all products
                    HttpResponseMessage response = client.GetAsync(baseUrl).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        Console.WriteLine("Response from server:");
                        Console.WriteLine(responseBody);
                    }
                    else
                    {
                        Console.WriteLine("Failed to retrieve products. Status code: " + response.StatusCode);
                    }

                    // You can send other types of requests (POST, PUT, DELETE) in a similar way
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            

            // Create an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Prepare the data to be sent in the POST request
                    string data = "{\"Id\": 5, \"Name\": \"New Product\"}";
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                    // Send a POST request to add a new product
                    HttpResponseMessage response = client.PostAsync(baseUrl, content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Product added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to add product. Status code: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
