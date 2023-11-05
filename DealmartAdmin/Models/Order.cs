using Newtonsoft.Json;

namespace DealmartAdmin.Models
{
    public class Order
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        public string BuyerId { get; set; }

        public string Address { get; set; }

        public List<OrderItem> OrderItemDetails { get; set; }

        public bool OrderAccepted { get; set; }
    }
}
