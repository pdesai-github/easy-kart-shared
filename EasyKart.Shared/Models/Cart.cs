
using Newtonsoft.Json;

namespace EasyKart.Shared.Models
{
    public class Cart
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("items")]
        public List<CartItem> Items { get; set; }

        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }
    }
}
