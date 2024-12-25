using Newtonsoft.Json;

namespace EasyKart.Shared.Models
{
    public class CartItem
    {
        [JsonProperty("product")]
        public Product Product { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
