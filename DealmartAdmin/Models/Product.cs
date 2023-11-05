using Newtonsoft.Json;

namespace DealmartAdmin.Models
{
    public class Product
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public int Sold { get; set; }
    }
}
