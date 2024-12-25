using Newtonsoft.Json;

namespace EasyKart.Shared.Models
{
    public class Category
    {

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
