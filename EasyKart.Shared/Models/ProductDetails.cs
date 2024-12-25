using Newtonsoft.Json;
using System.Dynamic;

namespace EasyKart.Shared.Models
{
    public class ProductDetails
    {
        [JsonProperty("productId")]
        public Guid ProductId { get; set; }

        [JsonProperty("technicalDetails")]
        public ExpandoObject TechnicalDetails { get; set; }

        [JsonProperty("aditionalDetails")]
        public ExpandoObject AditionalDetails { get; set; }

        [JsonProperty("attributes")]
        public ExpandoObject Attributes { get; set; }
    }
}
