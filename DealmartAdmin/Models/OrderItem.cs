using Newtonsoft.Json;

namespace DealmartAdmin.Models
{
    public class OrderItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        public string ProductId { get; set; }

        public string Quantity { get; set; }

        public Product ProductDetails { get; set; }
    }
}
