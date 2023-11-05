using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using DealmartAdmin.Models;
using System.Text;

namespace DealmartAdmin.Services
{
    public class OrderService
    {
        private readonly HttpClient _client;

        public OrderService()
        {
            _client = new HttpClient { BaseAddress = new Uri("https://e-commerce-q6ap.onrender.com/") };
        }

        public async Task<List<Order>> GetOrders()
        {
            HttpResponseMessage response = await _client.GetAsync("api/orders");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                List<Order> products = JsonConvert.DeserializeObject<List<Order>>(data);

                return products;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase, "Error", MessageBoxButtons.OK);
                return null;
            }
        }

        public async Task<bool> UpdateOrder(Order order)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var json = JsonConvert.SerializeObject(order, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PatchAsync("api/orders/" + order.Id, content);


            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Order accepted successfully!", "Done", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase, "Error", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
