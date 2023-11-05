using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using DealmartAdmin.DTOs;
using DealmartAdmin.Models;
using System.Text;

namespace DealmartAdmin.Services
{
    public class ProductService
    {
        private readonly HttpClient _client;

        public ProductService()
        {
            _client = new HttpClient { BaseAddress = new Uri("https://e-commerce-q6ap.onrender.com/") };
        }

        public async Task<List<Product>> GetProducts()
        {
            HttpResponseMessage response = await _client.GetAsync("api/product");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(data);

                return products;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase, "Error", MessageBoxButtons.OK);
                return null;
            }
        }

        public async Task<Product> GetProduct(string id)
        {
            HttpResponseMessage response = await _client.GetAsync("api/product/" + id);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                Product product = JsonConvert.DeserializeObject<Product>(data);

                return product;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase, "Error", MessageBoxButtons.OK);
                return null;
            }
        }

        public async Task<bool> CreateProduct(ProductCreateDto product)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var json = JsonConvert.SerializeObject(product, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("api/product", content);


            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product saved successfully!", "Done", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var json = JsonConvert.SerializeObject(product, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PatchAsync("api/product/" + product.Id, content);


            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product updated successfully!", "Done", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public async Task<bool> DeleteProduct(string id)
        {
            var response = await _client.DeleteAsync("api/product/" + id);


            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product Deleted successfully!", "Done", MessageBoxButtons.OK);
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
